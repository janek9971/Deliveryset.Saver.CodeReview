using DeliverysetService.Library.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DeliverysetService.Library.Services;

public record DeliverysetVersionInfo(DeliverysetByVersion? CurrentVersion, int NextVersion);

public record DeliverysetByVersion(long Id, int Version);

public class DeliverysetVersionInfoByIdRetrieve : IDeliverysetVersionInfoByIdRetrieve
{
    private readonly IApplicationDbContext _context;

    public DeliverysetVersionInfoByIdRetrieve(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DeliverysetVersionInfo> GetVersionInfo(long id, CancellationToken cancellationToken = default)
    {
        var currentVersion = await _context.ContentDeliveryset
            .Where(t => t.ContentId == id)
            .OrderByDescending(t => t.Version)
            .Select(t => t).FirstOrDefaultAsync(cancellationToken: cancellationToken);
        var nextVersionContentDeliveryset = (currentVersion?.Version ?? 0) + 1;

        return currentVersion switch
        {
            null => new DeliverysetVersionInfo(null, nextVersionContentDeliveryset),
            _ => new DeliverysetVersionInfo(new DeliverysetByVersion(currentVersion.Id, currentVersion.Version),
                nextVersionContentDeliveryset)
        };
    }
}