using DeliverysetService.Library.Persistence.Models.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DeliverysetService.Library.Persistence
{
    public class AuditableEntitySaveChangesInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            UpdateEntities(eventData.Context);

            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            UpdateEntities(eventData.Context);

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        public void UpdateEntities(DbContext? context)
        {
            if (context == null) return;

            foreach (var entry in context.ChangeTracker.Entries<AuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreationDate = DateTime.UtcNow;
                }

                if (entry.State is EntityState.Added or EntityState.Modified)
                {
                    entry.Entity.ModificationDate = DateTime.UtcNow;
                }
            }
            foreach (var entry in context.ChangeTracker.Entries<CreationEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreationDate = DateTime.UtcNow;
                }
            }
        }
    }
}
