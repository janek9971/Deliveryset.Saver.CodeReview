using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace DeliverysetService.Library.Persistence.Models.Json;

public class Essence
{
    public string Id { get; set; }
    public string ResourceId { get; set; }
    public bool Active { get; set; }
    [JsonProperty("_type")]
    [JsonPropertyName("_type")]
    public string Type { get; set; }
    public string AudioVersion { get; set; }
    public string Format { get; set; }
    public string SubtitleType { get; set; }
    public string Tag { get; set; }
    public int Index { get; set; }
    public ICollection<Position> Position { get; set; }
    public string Language { get; set; }
    public string VerificationStatus { get; set; }
    public string VideoVersion { get; set; }
    public string Resolution { get; set; }
    public string Fps { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
    public string AspectRation { get; set; }
    public string FrameRate { get; set; }
    public decimal FrameRateFloat { get; set; }
    public decimal FrameStartOfFile { get; set; }
    public decimal FrameEndOfFile { get; set; }
    public decimal FrameDuration { get; set; }
    public string CommercialName { get; set; }
    public string FormatProfile { get; set; }
    public decimal BitRate { get; set; }
    public string TcStartOfFile { get; set; }
    public string TcEndOfFile { get; set; }
    public string TcDuration { get; set; }
}