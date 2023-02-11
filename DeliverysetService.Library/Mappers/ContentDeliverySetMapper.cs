namespace DeliverysetService.Library.Mappers;

/*
public static class ContentDeliverysetMapper
{
    public static IQueryable<ContentDeliverysetDto> MapToContentDeliverysetDto(this IQueryable<ContentDeliveryset> queryable)
    {
        return queryable.Select(contentDeliveryset => new ContentDeliverysetDto(contentDeliveryset.Deliveryset,
            contentDeliveryset.ContentDeliverysetMetadata.AssetStatus,
            contentDeliveryset.Version, contentDeliveryset.IsDeleted));

    }
    public static IQueryable<ContentDeliverysetToPublishDto> MapToContentDeliverysetToPublishDto(this IQueryable<ContentDeliveryset> queryable)
    {
        return queryable.Select(cds => new ContentDeliverysetToPublishDto()
        {
            ContentBroadcasts = cds.Content.ContentBroadcast.Select(contentBroadcast => new ContentBroadcastDto
            {
                Channel = new ChannelDto
                {
                    Name = contentBroadcast.Channel.Name,
                    Code = contentBroadcast.Channel.Code,
                    CreationDate = contentBroadcast.Channel.CreationDate,
                    Id = contentBroadcast.Channel.Id,
                    PlayoutType = new PlayoutTypeDto(contentBroadcast.Channel.PlayoutType.Id,
                        contentBroadcast.Channel.PlayoutType.Code, contentBroadcast.Channel.PlayoutType.Name),
                    ModificationDate = contentBroadcast.Channel.ModificationDate,
                    TimeZone = contentBroadcast.Channel.TimeZone
                },
                NextBroadcastUtc = contentBroadcast.NextBroadcastUtc
            }),
            ContentDeliverysetMetadataId = cds.ContentDeliverysetMetadataId,
            Deliveryset = cds.Deliveryset,
            DeliverysetId = cds.DeliverysetId,
            Id = cds.Id,
            Priority = cds.ContentDeliverysetMetadata.Priority,
            Version = cds.Version,
            SubtitleFiles = cds.SubtitleFiles.Select(sf=> new SubtitleFilesDto()
            {
                Status = sf.Status,
                SubtitleType = sf.SubtitleType,
                FileId = sf.FileId,
            }),
            VideoFiles = cds.VideoFiles.Select(vf=> new VideoFilesDto()
            {
                Status = vf.Status,
                FileId = vf.FileId,
            })
        });

    }
}*/
