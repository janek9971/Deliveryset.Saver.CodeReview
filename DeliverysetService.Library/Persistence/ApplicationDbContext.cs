using System.Reflection;
using DeliverysetService.Library.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliverysetService.Library.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors().EnableSensitiveDataLogging(true);
        }

        public DbSet<AssetStatus> AssetStatus => Set<AssetStatus>();
        public DbSet<Content> Contents => Set<Content>();
        public DbSet<VideoFiles> VideoFiles => Set<VideoFiles>();
        public DbSet<SubtitleFiles> SubtitleFiles => Set<SubtitleFiles>();
        public DbSet<ContentDeliverysetMetadata> ContentDeliverysetMetadata => Set<ContentDeliverysetMetadata>();
        public DbSet<ContentDeliveryset> ContentDeliveryset => Set<ContentDeliveryset>();
        public DbSet<ContentBroadcast> ContentBroadcast => Set<ContentBroadcast>();
    }
}
