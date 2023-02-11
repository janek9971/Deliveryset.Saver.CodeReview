using DeliverysetService.Library.Persistence.Models.Enums;

namespace DeliverysetService.Library.Persistence.Models.Common.Interfaces
{
    public interface IFileEntity
    {
        public string FileId { get; set; }
        // public string FileName { get; set; }
        public FileStatus Status { get; set; }
    }
}
