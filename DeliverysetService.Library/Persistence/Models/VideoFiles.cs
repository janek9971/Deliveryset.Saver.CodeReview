using DeliverysetService.Library.Persistence.Models.Common;
using DeliverysetService.Library.Persistence.Models.Common.Interfaces;
using DeliverysetService.Library.Persistence.Models.Enums;

namespace DeliverysetService.Library.Persistence.Models;

public class VideoFiles : AuditableEntity, IFileEntity
{
    public long ContentDeliverysetId { get; set; }
    public ContentDeliveryset ContentDeliveryset { get; set; }
    // public string FileName { get; set; }
    public string FileId { get; set; }
    public FileStatus Status { get; set; }
}