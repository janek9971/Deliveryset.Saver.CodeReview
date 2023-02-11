using DeliverysetService.Library.Models;
using DeliverysetService.Library.Persistence.Models.Json;
using DeliverysetService.Library.Services.Comparers;

namespace DeliverysetService.Library.Services.DeliverysetFileDetectChangesHandlerStrategy;

public class DeliverysetSubtitleFilesDetectChangesHandler : IDeliverysetFileDetectChangesHandler
{
    public DeliverysetChangesResult GetDeliverysetChangesResult(Deliveryset currentDeliveryset, Deliveryset newDeliveryset)
    {
        return DeliverysetComparer.Init(newDeliveryset, currentDeliveryset).SubtitlesChanges();
    }
}