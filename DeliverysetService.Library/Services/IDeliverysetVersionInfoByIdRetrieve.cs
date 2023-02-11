namespace DeliverysetService.Library.Services;

public interface IDeliverysetVersionInfoByIdRetrieve
{
    Task<DeliverysetVersionInfo> GetVersionInfo(long id, CancellationToken cancellationToken = default);
}