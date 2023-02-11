namespace DeliverysetService.Library.Models;

public record DeliverysetChangesResult(bool IsAllAreEqual, List<string> NotChangedByKeyList);