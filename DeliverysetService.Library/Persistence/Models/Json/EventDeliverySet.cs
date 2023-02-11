using Newtonsoft.Json;

namespace DeliverysetService.Library.Persistence.Models.Json;

public class EventDeliveryset
{

    [JsonProperty("id")]
    public string EventId { get; set; }
    public Deliveryset Data { get; set; }
    public EventDeliverysetType EventType { get; set; }
}