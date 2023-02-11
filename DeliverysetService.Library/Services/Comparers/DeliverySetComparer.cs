using DeliverysetService.Library.Models;
using DeliverysetService.Library.Persistence.Models.Json;
using KellermanSoftware.CompareNetObjects;

namespace DeliverysetService.Library.Services.Comparers
{

    public static class CompareLogicSettings
    {
        public static ComparisonConfig ComparisonConfig = new()
        {
            CaseSensitive = false,
            UseHashCodeIdentifier = true,
            CompareChildren = true,
            MaxStructDepth = 5,
        };
    }


    public class DeliverysetComparer
    {
        private readonly Deliveryset _newDeliveryset;
        private readonly Deliveryset _currentDeliveryset;
        // private readonly HashSet<DeliverysetChange> _deliverySetChanges = new HashSet<DeliverysetChange>();
        private readonly CompareLogic _compareLogic = new(CompareLogicSettings.ComparisonConfig);

        private DeliverysetComparer(Deliveryset newDeliveryset, Deliveryset currentDeliveryset)
        {
            _newDeliveryset = newDeliveryset;
            _currentDeliveryset = currentDeliveryset;
        }
        public static DeliverysetComparer Init(Deliveryset newDeliveryset, Deliveryset currentDeliveryset)
        {
            return new DeliverysetComparer(newDeliveryset, currentDeliveryset);
        }

        public DeliverysetChangesResult AssetsChanges()
        {
            var comparisonResult = _compareLogic.Compare(_newDeliveryset.Asset, _currentDeliveryset.Asset);
            var assetAreEqual = comparisonResult.AreEqual;
            return new DeliverysetChangesResult(assetAreEqual, new List<string>());
        }

        // public DeliverysetComparer CompareAllPackages()
        // {
        //     var packageComparer = PackageComparer.Init(_newDeliveryset.Packages, _currentDeliveryset.Packages).SubtitlesAreEqual().VideosAreEqual();
        //     _deliverySetChanges.UnionWith(packageComparer.GetComparisionResult());
        //
        //     return this;
        // }
        public DeliverysetChangesResult SubtitlesChanges()
        {
            var comparer = PackageComparer.Init(_newDeliveryset.Packages, _currentDeliveryset.Packages);
            return comparer.SubtitlesChanges();

        }
        public DeliverysetChangesResult VideosChanges()
        {
            var comparer = PackageComparer.Init(_newDeliveryset.Packages, _currentDeliveryset.Packages);
            return comparer.VideosChanges();
        }
    }
}