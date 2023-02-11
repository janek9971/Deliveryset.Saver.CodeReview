using DeliverysetService.Library.Models;
using DeliverysetService.Library.Persistence.Models.Enums;
using DeliverysetService.Library.Persistence.Models.Json;
using KellermanSoftware.CompareNetObjects;

namespace DeliverysetService.Library.Services.Comparers;

internal class PackageComparer
{
    private readonly IList<Package> _newPackage;
    private readonly IList<Package> _currentPackage;
    // private readonly List<DeliverysetChange> _deliverySetChanges = new List<DeliverysetChange>();
    private readonly CompareLogic _compareLogic = new(CompareLogicSettings.ComparisonConfig);


    public static PackageComparer Init(IList<Package> newPackage, IList<Package> currentPackage)
    {
        return new PackageComparer(newPackage, currentPackage);
    }

    private PackageComparer(IList<Package> newPackage, IList<Package> currentPackage)
    {
        _newPackage = newPackage;
        _currentPackage = currentPackage;
    }

    public DeliverysetChangesResult VideosChanges()
    {
        var currentVideo = _currentPackage.SingleOrDefault(t =>
            t.File.FileType.Equals(EssenceFileType.Video.ToString("G"), StringComparison.OrdinalIgnoreCase));


        var newVideo = _newPackage.SingleOrDefault(t =>
            t.File.FileType.Equals(EssenceFileType.Video.ToString("G"), StringComparison.OrdinalIgnoreCase));
        var areEqual = _compareLogic.Compare(currentVideo?.Essences, newVideo?.Essences).AreEqual;

        return new DeliverysetChangesResult(areEqual, new List<string>());
    }

    public DeliverysetChangesResult SubtitlesChanges()
    {
        var currentVideoSubtitles = _currentPackage.Where(t =>
                t.File.FileType.Equals(EssenceFileType.Sub.ToString("G"), StringComparison.OrdinalIgnoreCase))
            .SelectMany(t => t.Essences).OrderBy(t => t.SubtitleType).ToList();

        var newVideoSubtitles = _newPackage.Where(t =>
                t.File.FileType.Equals(EssenceFileType.Sub.ToString("G"), StringComparison.OrdinalIgnoreCase))
            .SelectMany(t => t.Essences).OrderBy(t => t.SubtitleType).ToList();

        var intersectSubtitleTypes =
            currentVideoSubtitles
                .IntersectBy(newVideoSubtitles.Select(essence => essence.SubtitleType), t => t.SubtitleType)
                .Select(t => t.SubtitleType);

        List<string> notChangedSubtitleTypes = new List<string>();

        foreach (var subType in intersectSubtitleTypes)
        {
            var currentSub = currentVideoSubtitles.First(t => t.SubtitleType == subType);
            var newSub = currentVideoSubtitles.First(t => t.SubtitleType == subType);

            var comparisonResult = _compareLogic.Compare(currentSub, newSub);
            if (comparisonResult.AreEqual)
            {
                notChangedSubtitleTypes.Add(subType);
            }
        }


        var areEqual = _compareLogic.Compare(newVideoSubtitles, currentVideoSubtitles).AreEqual;

        return new DeliverysetChangesResult(areEqual, notChangedSubtitleTypes);
    }
}