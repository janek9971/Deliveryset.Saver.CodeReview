using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;

public class DeliverysetSubtitleFilesCopyHandler : IDeliverysetFileCopyHandler<SubtitleFiles>
{
    public IEnumerable<SubtitleFiles> GetFilesToCopy(List<SubtitleFiles>? entities)
    {
        if (entities == null) yield break;

        foreach (var entity in entities)
        {
            yield return new SubtitleFiles()
            {
                FileId = entity.FileId,
                Status = entity.Status,
                SubtitleType = entity.SubtitleType
            };
        }
    }
}