
// some test code

using DeliverysetService.Library;
using DeliverysetService.Library.Persistence.Models.Json;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddLibraryServices();
    })
    .Build();

using var testScope = host.Services.CreateScope();

var saver =testScope.ServiceProvider.GetRequiredService<IDeliverysetSaverService>();


var someDeliveryset = new Deliveryset();
await saver.SaveDeliveryset(someDeliveryset);

