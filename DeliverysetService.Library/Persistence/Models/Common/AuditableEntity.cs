namespace DeliverysetService.Library.Persistence.Models.Common;

public abstract class AuditableEntity : CreationEntity
{
    public DateTime ModificationDate { get; set; }
}