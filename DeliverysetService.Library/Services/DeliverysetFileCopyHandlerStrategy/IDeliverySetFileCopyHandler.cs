using DeliverysetService.Library.Persistence.Models.Common.Interfaces;

namespace DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;

public interface IDeliverysetFileCopyHandler
{
}
public interface IDeliverysetFileCopyHandler<T> : IDeliverysetFileCopyHandler where T : IFileEntity
{
    IEnumerable<T> GetFilesToCopy(List<T> entities);
}