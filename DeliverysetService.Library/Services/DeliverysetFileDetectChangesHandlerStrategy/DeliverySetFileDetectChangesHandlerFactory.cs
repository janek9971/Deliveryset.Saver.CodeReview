using DeliverysetService.Library.Enums;

namespace DeliverysetService.Library.Services.DeliverysetFileDetectChangesHandlerStrategy;

public class DeliverysetFileDetectChangesHandlerFactory : IDeliverysetFileDetectChangesHandlerFactory
{
    private readonly IDictionary<DeliverysetChange, IDeliverysetFileDetectChangesHandler> _map;

    public DeliverysetFileDetectChangesHandlerFactory(IDictionary<DeliverysetChange, IDeliverysetFileDetectChangesHandler> map)
    {
        _map = map;
    }

    public IDeliverysetFileDetectChangesHandler GetDeliverysetFileCopyHandler(DeliverysetChange deliverySetChange)
    {
        return _map[deliverySetChange];
    }
}