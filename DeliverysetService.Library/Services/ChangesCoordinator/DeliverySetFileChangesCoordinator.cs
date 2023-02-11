using DeliverysetService.Library.Enums;
using DeliverysetService.Library.Models;
using DeliverysetService.Library.Persistence;
using DeliverysetService.Library.Persistence.Models;
using DeliverysetService.Library.Persistence.Models.Json;
using DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;
using DeliverysetService.Library.Services.DeliverysetFileDetectChangesHandlerStrategy;
using Microsoft.EntityFrameworkCore;

namespace DeliverysetService.Library.Services.ChangesCoordinator;

public class DeliverysetFileChangesCoordinator : IDeliverysetFileChangesCoordinator
{
    private readonly IApplicationDbContext _context;
    private readonly IDeliverysetFileCopyHandlerFactory _deliverySetFileCopyHandlerFactory;
    private readonly IDeliverysetFileDetectChangesHandlerFactory _detectChangesHandlerFactory;
    private IEnumerable<VideoFiles> _videoFiles = Array.Empty<VideoFiles>();
    private IEnumerable<SubtitleFiles> _subtitleFiles = Array.Empty<SubtitleFiles>();
    private bool _anyChanges;

    public DeliverysetFileChangesCoordinator(IApplicationDbContext context, IDeliverysetFileCopyHandlerFactory deliverySetFileCopyHandlerFactory, IDeliverysetFileDetectChangesHandlerFactory detectChangesHandlerFactory)
    {
        _context = context;
        _deliverySetFileCopyHandlerFactory = deliverySetFileCopyHandlerFactory;
        _detectChangesHandlerFactory = detectChangesHandlerFactory;
    }
    public async Task<DeliverysetChangesInfo> GetDeliverysetChangesInfo(DeliverysetVersionInfo deliverySetVersionInfo, Deliveryset newDeliveryset, CancellationToken cancellationToken = default)
    {
        if (deliverySetVersionInfo.CurrentVersion == null)
        {
            return new DeliverysetChangesInfo(true, Array.Empty<VideoFiles>(), Array.Empty<SubtitleFiles>());
        }
        var currentNewestDeliveryset =
            await _context.ContentDeliveryset.AsNoTracking().Where(d => d.Id == deliverySetVersionInfo.CurrentVersion.Id)
                .Select(t => new
                {
                    t.Deliveryset,
                    t.VideoFiles,
                    t.SubtitleFiles,
                    t.Version
                }).SingleAsync(cancellationToken: cancellationToken);




        foreach (var deliverySetChange in Enum.GetValues<DeliverysetChange>())
        {
            var changesHandler = _detectChangesHandlerFactory.GetDeliverysetFileCopyHandler(deliverySetChange);
            var changesResult = changesHandler.GetDeliverysetChangesResult(currentNewestDeliveryset.Deliveryset, newDeliveryset);

            if (!changesResult.IsAllAreEqual)
            {
                _anyChanges = true;
            }
            if (changesResult.IsAllAreEqual && deliverySetChange == DeliverysetChange.Video)
            {
                var copyHandler = _deliverySetFileCopyHandlerFactory.GetDeliverysetFileCopyHandler<VideoFiles>(DeliverysetFileCopyHandler.Video);
                _videoFiles = copyHandler.GetFilesToCopy(currentNewestDeliveryset.VideoFiles);
            }

            if (deliverySetChange == DeliverysetChange.Subtitle)
                _subtitleFiles = GetSubtitlesToCopy(changesResult, currentNewestDeliveryset.SubtitleFiles);
        }

        return new DeliverysetChangesInfo(_anyChanges, _videoFiles, _subtitleFiles);
    }



    private IEnumerable<SubtitleFiles> GetSubtitlesToCopy(DeliverysetChangesResult changesResult, List<SubtitleFiles> currentDeliverysetSubFiles)
    {
        var copy = _deliverySetFileCopyHandlerFactory.GetDeliverysetFileCopyHandler<SubtitleFiles>(DeliverysetFileCopyHandler.Sub);

        bool FilterNotChangedSubtitleTypes(SubtitleFiles t) => changesResult.NotChangedByKeyList.Contains(t.SubtitleType);

        var subtitleFilesList = changesResult.IsAllAreEqual
            ? currentDeliverysetSubFiles
            : currentDeliverysetSubFiles.Where(FilterNotChangedSubtitleTypes).ToList();

        var subtitleFilesEnumerable = copy.GetFilesToCopy(subtitleFilesList);
        return subtitleFilesEnumerable;
    }
}