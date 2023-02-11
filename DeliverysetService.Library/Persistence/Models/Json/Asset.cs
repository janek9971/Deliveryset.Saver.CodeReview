namespace DeliverysetService.Library.Persistence.Models.Json;

public class Asset
{
    public string Id { get; set; }
    public string HouseId { get; set; }
    public int ProductionNr => Convert.ToInt32(HouseId.Split("_")[0]);
    public int ProgramNr => Convert.ToInt32(HouseId.Split("_")[1]);
    public string HouseOrigin { get; set; }
    public ICollection<Locator> Locators { get; set; }
    public Version Version { get; set; }
    public Titles Titles { get; set; }
}