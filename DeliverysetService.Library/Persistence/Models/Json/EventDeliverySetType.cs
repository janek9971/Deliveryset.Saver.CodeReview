using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DeliverysetService.Library.Persistence.Models.Json;

[JsonConverter(typeof(StringEnumConverter))]
public enum EventDeliverysetType
{
    [EnumMember(Value = "created")] Created,
    [EnumMember(Value = "updated")] Updated,
    [EnumMember(Value = "deleted")] Deleted
}