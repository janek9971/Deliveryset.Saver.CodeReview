using DeliverysetService.Library.Persistence;
using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Services.DataServices;

public class DeliverysetService : IDeliverysetService
{
    private readonly IApplicationDbContext _context;
    public DeliverysetService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Save(ContentDeliveryset contentDelivery, CancellationToken cancellationToken = default)
    {
        _context.ContentDeliveryset.Add(contentDelivery);
        await _context.SaveChangesAsync(cancellationToken);
    }

    // public IQueryable<ContentDeliverysetDto?> GetContentDeliveryset(long id)
    // {
    // }
    //
    // public IQueryable<ContentDeliverysetToPublishDto?> GetDeliverysetsNotRequestedByNearestBroadcastAndMaxPriority(IEnumerable<long> filterIds)
    // {

    // }
    //
    // public IQueryable<ContentDeliverysetDto> GetContentDeliverysetByHouseId(HouseIdValueObject houseIdValueObject)
    // {
    //     return _context.ContentDeliveryset.Where(contentDeliveryset =>
    //         contentDeliveryset.Content.ProductionNr == houseIdValueObject.ProductionNr &&
    //         contentDeliveryset.Content.ProgramNr == houseIdValueObject.ProgramNr).MapToContentDeliverysetDto();
    // }
    //
    // public IQueryable<ContentDeliverysetDto> GetContentDeliverysetBySomeId(
    //     SomeIdValueObject someIdValueObject)
    // {

    // }
}