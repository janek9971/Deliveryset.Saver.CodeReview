using DeliverysetService.Library.Enums;
using DeliverysetService.Library.Persistence.Models.Common.Interfaces;

namespace DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;

public class DeliverysetFileCopyHandlerFactory : IDeliverysetFileCopyHandlerFactory
{
    private readonly IDictionary<DeliverysetFileCopyHandler, IDeliverysetFileCopyHandler> _map;

    public DeliverysetFileCopyHandlerFactory(IDictionary<DeliverysetFileCopyHandler, IDeliverysetFileCopyHandler> map)
    {
        _map = map;
    }

    public IDeliverysetFileCopyHandler<T> GetDeliverysetFileCopyHandler<T>(DeliverysetFileCopyHandler copyMethod) where T : IFileEntity
    {
        var deliverySetFileCopyHandler = _map[copyMethod];
        return (IDeliverysetFileCopyHandler<T>)deliverySetFileCopyHandler;
    }
}