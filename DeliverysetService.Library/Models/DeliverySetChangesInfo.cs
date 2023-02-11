using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Models;

public record DeliverysetChangesInfo(bool HasChanges, IEnumerable<VideoFiles> VideoFiles, IEnumerable<SubtitleFiles> SubtitleFiles);