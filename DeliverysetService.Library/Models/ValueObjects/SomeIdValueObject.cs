using Microsoft.AspNetCore.Mvc;

namespace DeliverysetService.Library.Models.ValueObjects;

public record SomeIdValueObject
{
    [FromRoute(Name = "productionNr")] public int ProductionNr { get; init; }
    [FromRoute(Name = "programNr")] public int ProgramNr { get; init; }
    [FromRoute(Name = "version")] public string Version { get; init; }
    [FromRoute(Name = "format")] public string Format { get; init; }

    public SomeIdValueObject(){}
    public SomeIdValueObject(string someId)
    {
        var idSplit = someId.Split('_');

        ProductionNr = int.Parse(idSplit[0]);
        ProgramNr = int.Parse(idSplit[1]);
        Version = idSplit[2];
        Format = idSplit[3];
    }

    public SomeIdValueObject(int productionNr, int programNr, string version, string format)
    {
        ProductionNr = productionNr;
        ProgramNr = programNr;
        Version = version;
        Format = format;
    }

    public override string ToString()
    {
        return $"{ProductionNr}_{ProgramNr}_{Version}_{Format}";
    }

    public void Deconstruct(out string someTrafficId, out string houseId)
    {
        someTrafficId = $"{ProductionNr}_{ProgramNr}_{Version}_{Format}";
        houseId = $"{ProductionNr}_{ProgramNr}";
    }


}