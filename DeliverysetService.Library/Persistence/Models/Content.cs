using DeliverysetService.Library.Persistence.Models.Common;

namespace DeliverysetService.Library.Persistence.Models
{
    public class Content : CreationEntity
    {
        public int ProductionNr { get; set; }

        public int ProgramNr { get; set; }

        public string Format { get; set; }

        public string Version { get; set; }

      
        public List<ContentBroadcast> ContentBroadcast { get; set; } = new List<ContentBroadcast>();
        public List<ContentDeliveryset> ContentDeliveryset { get; set; } = new List<ContentDeliveryset>();

        public override string ToString()
        {
            return $"{Id}, {CreationDate}, {ProductionNr}, {ProgramNr}, {Format}, {Version}";
        }
    }
}