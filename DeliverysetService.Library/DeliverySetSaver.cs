using DeliverysetService.Library.Models.ValueObjects;
using DeliverysetService.Library.Persistence;
using DeliverysetService.Library.Persistence.Models;
using DeliverysetService.Library.Persistence.Models.Json;
using DeliverysetService.Library.Services;
using DeliverysetService.Library.Services.ChangesCoordinator;
using DeliverysetService.Library.Services.DataServices;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DeliverysetService.Library;

public interface IDeliverysetSaverService
{
    Task<bool> SaveDeliveryset(Deliveryset? deliverySet, bool isDeletedFlag = false, CancellationToken cancellationToken = default);
}

public class DeliverysetSaverService : IDeliverysetSaverService
{
    private readonly IApplicationDbContext _context;
    private readonly IDeliverysetVersionInfoByIdRetrieve _deliverysetVersionInfoByIdRetrieve;
    private readonly IAssetStatusMapRetriever _assetStatusMapRetriever;
    private readonly ILogger<DeliverysetSaverService> _logger;
    private readonly IDeliverysetService _deliverySetService;
    private readonly IValidator<Deliveryset> _deliverySetValidator;
    private readonly IDeliverysetFileChangesCoordinator _deliverySetFileChangesCoordinator;

    public DeliverysetSaverService(IApplicationDbContext context, IDeliverysetVersionInfoByIdRetrieve deliverysetVersionInfoByIdRetrieve, IAssetStatusMapRetriever assetStatusMapRetriever, ILogger<DeliverysetSaverService> logger, IDeliverysetService deliverySetService, IValidator<Deliveryset> deliverySetValidator, IDeliverysetFileChangesCoordinator deliverySetFileChangesCoordinator)
    {
        _context = context;
        _deliverysetVersionInfoByIdRetrieve = deliverysetVersionInfoByIdRetrieve;
        _assetStatusMapRetriever = assetStatusMapRetriever;
        _logger = logger;
        _deliverySetService = deliverySetService;
        _deliverySetValidator = deliverySetValidator;
        _deliverySetFileChangesCoordinator = deliverySetFileChangesCoordinator;
    }

    public async Task<bool> SaveDeliveryset(Deliveryset? deliverySet, bool isDeletedFlag = false,
        CancellationToken cancellationToken = default)
    {
        if (deliverySet == null) return false;
        var validationResult = await _deliverySetValidator.ValidateAsync(deliverySet, cancellationToken);
        if (!validationResult.IsValid)
        {
            _logger.LogWarning("Deliveryset validation failed, reason: {reason}", validationResult.ToString());
            return false;
        }


        var id = new SomeIdValueObject(deliverySet.Tags.MhtId);

        var contentId = (await _context.Contents.SingleOrDefaultAsync(content =>
            content.ProductionNr == id.ProductionNr && content.ProgramNr == id.ProgramNr
                                                    && content.Version == id.Version && content.Format == id.Format, cancellationToken: cancellationToken))?.Id;

        var (someTrafficId, _) = id;

        if (!contentId.HasValue)
        {
            _logger.LogWarning(
                "Content for id:{id} was not found when saving delivery set", someTrafficId);
            return false;
        }

        var deliverySetVersion =
            await _deliverysetVersionInfoByIdRetrieve.GetVersionInfo(contentId.Value, cancellationToken);

        var deliverySetChangesInfo = await _deliverySetFileChangesCoordinator.GetDeliverysetChangesInfo(deliverySetVersion, deliverySet, cancellationToken);
        if (!deliverySetChangesInfo.HasChanges)
        {
            return false;
        }

        var contentDeliveryset = new ContentDeliveryset
        {
            ContentDeliverysetMetadata = new ContentDeliverysetMetadata()
            {
                AssetStatusId = _assetStatusMapRetriever.GetAssetStatusMap()["some_code"].Id
            },
            Deliveryset = deliverySet,
            ContentId = contentId,
            Version = deliverySetVersion.NextVersion,
            DeliverysetId = deliverySet.Id,
            SubtitleFiles = deliverySetChangesInfo.SubtitleFiles.ToList(),
            VideoFiles = deliverySetChangesInfo.VideoFiles.ToList(),
            IsDeleted = isDeletedFlag
        };

        await _deliverySetService.Save(contentDeliveryset, cancellationToken);
        return true;
    }
}