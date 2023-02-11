using DeliverysetService.Library.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DeliverysetService.Library.Persistence;

public interface IApplicationDbContext
{
    DbSet<AssetStatus> AssetStatus { get; }
    DbSet<Content> Contents { get; }
    DbSet<ContentDeliverysetMetadata> ContentDeliverysetMetadata { get; }
    DbSet<ContentDeliveryset> ContentDeliveryset { get; }
    DbSet<VideoFiles> VideoFiles { get; }
    DbSet<SubtitleFiles> SubtitleFiles { get; }
    DbSet<ContentBroadcast> ContentBroadcast { get; }
    // DbSet<IngestListLog> IngestListLogs { get; }
    DatabaseFacade Database { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}