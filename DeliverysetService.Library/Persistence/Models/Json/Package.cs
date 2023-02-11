using Newtonsoft.Json;

namespace DeliverysetService.Library.Persistence.Models.Json;

public class Package
{
    public string Id { get; set; }
    public ICollection<Essence> Essences { get; set; } = new List<Essence>();
    public ICollection<File> Files { get; set; } = new List<File>();
    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public File File => Files.FirstOrDefault()!;
}