using DeliverysetService.Library.Persistence.Models.Common;

namespace DeliverysetService.Library.Persistence.Models
{
    public class ContentBroadcast : AuditableEntity
    {
        public DateTime NextBroadcastUtc { get; set; }
        public long ChannelId { get; set; }

        public Channel Channel { get; set; }
        public DateTime? NextBroadcast
        {
            get
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
                if (Channel != null)
                    return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(NextBroadcastUtc, Channel.TimeZone);
                return null;
            }
        }
        public long ContentId { get; set; }
        public Content Content { get; set; }
    }
}
