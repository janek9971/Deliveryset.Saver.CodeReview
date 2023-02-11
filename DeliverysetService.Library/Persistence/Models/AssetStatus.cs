using DeliverysetService.Library.Persistence.Models.Common;

namespace DeliverysetService.Library.Persistence.Models;

public class AssetStatus : AuditableEntity
{
    public string Code { get; set; }

    public string Name { get; set; }
    public int Weight { get; set; }

    public IList<ContentDeliverysetMetadata> ContentDeliverysetMetadata { get; set; }
}