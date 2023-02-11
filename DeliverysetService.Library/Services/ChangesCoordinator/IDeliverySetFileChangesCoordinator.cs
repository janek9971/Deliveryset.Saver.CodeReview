using DeliverysetService.Library.Models;
using DeliverysetService.Library.Persistence.Models.Json;

namespace DeliverysetService.Library.Services.ChangesCoordinator;

public interface IDeliverysetFileChangesCoordinator
{
    Task<DeliverysetChangesInfo> GetDeliverysetChangesInfo(DeliverysetVersionInfo deliverySetVersionInfo,
        Deliveryset newDeliveryset,
        CancellationToken cancellationToken = default); // IEnumerable<FileEntity> GetFilesToCopy();
}