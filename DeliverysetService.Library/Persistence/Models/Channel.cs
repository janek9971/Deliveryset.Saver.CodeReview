using DeliverysetService.Library.Persistence.Models.Common;

namespace DeliverysetService.Library.Persistence.Models
{
    public class Channel : AuditableEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string TimeZone { get; set; }

        public IList<ContentBroadcast> Contents { get; set; } = new List<ContentBroadcast>();

        // public IList<IngestListLog> IngestListLogs { get; set; } = new List<IngestListLog>();
    }
}