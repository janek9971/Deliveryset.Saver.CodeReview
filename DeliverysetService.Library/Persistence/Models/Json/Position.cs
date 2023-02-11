using Newtonsoft.Json;

namespace DeliverysetService.Library.Persistence.Models.Json;

public class Position
{
    public string Index { get; set; }
    [JsonProperty("position")]
    public string PositionValue { get; set; }
}