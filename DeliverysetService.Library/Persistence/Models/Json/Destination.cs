namespace DeliverysetService.Library.Persistence.Models.Json;

public class Destination
{
    public string Territory { get; set; }
    public ICollection<string> DestinationCodes { get; set; }
}