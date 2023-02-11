using DeliverysetService.Library.Persistence.Models;

namespace DeliverysetService.Library.Services;

public interface IAssetStatusMapRetriever
{
    Dictionary<string, AssetStatus> GetAssetStatusMap();
}