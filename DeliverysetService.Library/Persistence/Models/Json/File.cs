using DeliverysetService.Library.Persistence.Models.Enums;

namespace DeliverysetService.Library.Persistence.Models.Json;

public class File
{
    public string FileType { get; set; } = null!;

    [System.Text.Json.Serialization.JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    public EssenceFileType? EssenceFileType
    {
        get
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (FileType == null) return null;
            var canBeParsed = Enum.TryParse(typeof(EssenceFileType), FileType, true, out _);

            if (!canBeParsed) return null;
            var essenceFileType = Enum.Parse<EssenceFileType>(FileType, true);
            return essenceFileType;

        }
    }
}