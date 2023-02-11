namespace DeliverysetService.Library.Persistence.Models.Json;

public class Deliveryset
{
    public string Id { get; set; }
    public string CompositionId { get; set; }
    public Asset Asset { get; set; }
    public Destination Destination { get; set; }
    public List<Package> Packages { get; set; }
    public string DeliveryFormat { get; set; }
    public Tag Tags { get; set; }
    public string CreatedAt { get; set; }
}