using DeliverysetService.Library.Persistence;
using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Services;

public class AssetStatusMapRetriever : IAssetStatusMapRetriever
{
    private Dictionary<string, AssetStatus>? _assetStatusMap;
    private readonly IApplicationDbContext _context;

    public AssetStatusMapRetriever(IApplicationDbContext context)
    {
        _context = context;
    }

    public Dictionary<string, AssetStatus> GetAssetStatusMap()
    {
        _assetStatusMap ??= _context.AssetStatus.AsEnumerable().ToDictionary(key => key.Code, key => key);
        return _assetStatusMap;
    }
}