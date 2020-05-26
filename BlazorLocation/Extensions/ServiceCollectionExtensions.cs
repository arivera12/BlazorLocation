using Microsoft.Extensions.DependencyInjection;
namespace BlazorLocation
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the BlazorLocation service to the service collection.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBlazorLocation(this IServiceCollection services)
        {
            return services.AddScoped<IBlazorLocationService, BlazorLocationService>();
        }
    }
}
