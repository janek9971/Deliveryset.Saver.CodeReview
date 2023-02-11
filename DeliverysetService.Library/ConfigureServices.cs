using DeliverysetService.Library.Enums;
using DeliverysetService.Library.Persistence.Models.Json;
using DeliverysetService.Library.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using DeliverysetService.Library.Persistence;
using DeliverysetService.Library.Services.DataServices;
using Microsoft.EntityFrameworkCore;
using DeliverysetService.Library.Services.DeliverysetFileCopyHandlerStrategy;
using DeliverysetService.Library.Services.DeliverysetFileDetectChangesHandlerStrategy;
using DeliverysetService.Library.Services.ChangesCoordinator;
using DeliverysetService.Library.Services;

namespace DeliverysetService.Library
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddLibraryServices(this IServiceCollection services)
        {
            var dummyConnString = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword";

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(dummyConnString));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();

            services.AddDeliverysetServices();


            return services;
        }
        public static IServiceCollection AddDeliverysetServices(this IServiceCollection services)
        {
            services.AddScoped<IValidator<Deliveryset>, DeliverysetValidator>();
            services.AddScoped<IDeliverysetSaverService, DeliverysetSaverService>();
            services.AddScoped<IAssetStatusMapRetriever, AssetStatusMapRetriever>();
            services.AddScoped<IDeliverysetVersionInfoByIdRetrieve, DeliverysetVersionInfoByIdRetrieve>();
            services.AddScoped<IDeliverysetService, Services.DataServices.DeliverysetService>();
            services.AddScoped<IDeliverysetFileChangesCoordinator, DeliverysetFileChangesCoordinator>();
            services.AddSingleton<IDeliverysetFileCopyHandlerFactory, DeliverysetFileCopyHandlerFactory>(_ =>
            {
                var deliverySetFileCopyHandlers =
                    new Dictionary<DeliverysetFileCopyHandler, IDeliverysetFileCopyHandler>
                    {
                        { DeliverysetFileCopyHandler.Video, new DeliverysetVideoFilesCopyHandler() },
                        { DeliverysetFileCopyHandler.Sub, new DeliverysetSubtitleFilesCopyHandler() }
                    };
                return new DeliverysetFileCopyHandlerFactory(deliverySetFileCopyHandlers);
            });
            services.AddSingleton<IDeliverysetFileDetectChangesHandlerFactory, DeliverysetFileDetectChangesHandlerFactory>(_ =>
            {
                var deliverySetFileDetectChangesHandlers =
                    new Dictionary<DeliverysetChange, IDeliverysetFileDetectChangesHandler>
                    {
                        { DeliverysetChange.Video, new DeliverysetVideoFilesDetectChangesHandler() },
                        { DeliverysetChange.Asset, new DeliverysetAssetsDetectChangesHandler() },
                        { DeliverysetChange.Subtitle, new DeliverysetSubtitleFilesDetectChangesHandler() }
                    };
                return new DeliverysetFileDetectChangesHandlerFactory(deliverySetFileDetectChangesHandlers);
            });
            return services;
        }
    }
}
