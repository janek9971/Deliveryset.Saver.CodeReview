using DeliverysetService.Library.Enums;
using DeliverysetService.Library.Persistence.Models.Common.Interfaces;

namespace DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;

public interface IDeliverysetFileCopyHandlerFactory
{
    IDeliverysetFileCopyHandler<T> GetDeliverysetFileCopyHandler<T>(DeliverysetFileCopyHandler copyMethod) where T : IFileEntity;
}