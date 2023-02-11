using DeliverysetService.Library.Persistence.Models.Common;

namespace DeliverysetService.Library.Persistence.Models
{
    public class ContentDeliverysetMetadata : CreationEntity
    {
        public long AssetStatusId { get; set; }

        public AssetStatus AssetStatus { get; set; }
        public int Priority { get; set; }

        // public long? ContentDeliverysetId { get; set; }
    }
}