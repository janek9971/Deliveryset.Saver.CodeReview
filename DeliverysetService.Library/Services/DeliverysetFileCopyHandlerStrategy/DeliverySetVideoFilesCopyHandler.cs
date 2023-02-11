using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;

public class DeliverysetVideoFilesCopyHandler : IDeliverysetFileCopyHandler<VideoFiles>
{
    public IEnumerable<VideoFiles> GetFilesToCopy(List<VideoFiles>? entities)
    {
        if (entities == null) yield break;

        foreach (var entity in entities)
        {
            yield return new VideoFiles()
            {
                FileId = entity.FileId,
                Status = entity.Status,
            };
        }
    }
}