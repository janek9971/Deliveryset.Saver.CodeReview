using DeliverysetService.Library.Models;
using DeliverysetService.Library.Persistence.Models.Json;

namespace DeliverysetService.Library.Services.DeliverysetFileDetectChangesHandlerStrategy;

public interface IDeliverysetFileDetectChangesHandler
{
    DeliverysetChangesResult GetDeliverysetChangesResult(Deliveryset currentDeliveryset, Deliveryset newDeliveryset);
}