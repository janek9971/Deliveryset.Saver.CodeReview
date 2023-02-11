using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Services.DataServices;

public interface IDeliverysetService
{
    Task Save(ContentDeliveryset contentDelivery, CancellationToken cancellationToken = default);
    // IQueryable<ContentDeliverysetDto?> GetContentDeliveryset(long id);
    // IQueryable<ContentDeliverysetDto> GetContentDeliverysetByHouseId(HouseIdValueObject houseIdValueObject);
    // IQueryable<ContentDeliverysetDto> GetContentDeliverysetBySomeId(SomeIdValueObject someIdValueObject);
}