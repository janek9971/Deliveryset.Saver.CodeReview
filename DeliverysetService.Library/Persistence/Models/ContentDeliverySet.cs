using DeliverysetService.Library.Persistence.Models.Common;
using DeliverysetService.Library.Persistence.Models.Json;

namespace DeliverysetService.Library.Persistence.Models
{
    public class ContentDeliveryset : CreationEntity
    {
        public long? ContentId { get; set; }
        public Content Content { get; set; }
        public Deliveryset Deliveryset { get; set; }
        public string DeliverysetId { get; set; }
        public int Version { get; set; }
        public bool IsDeleted { get; set; }
        public long ContentDeliverysetMetadataId { get; set; }
        public ContentDeliverysetMetadata ContentDeliverysetMetadata { get; set; }
        public List<VideoFiles> VideoFiles { get; set; } = new List<VideoFiles>();
        public List<SubtitleFiles> SubtitleFiles { get; set; } = new List<SubtitleFiles>();
    }
}
