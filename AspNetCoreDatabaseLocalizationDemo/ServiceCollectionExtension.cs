using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreDatabaseLocalizationDemo
{
    public static class ServiceCollectionExtension
    {
        public static TService GetService<TService>(this IServiceCollection services)
        {
            return services.BuildServiceProvider().GetRequiredService<TService>();
        }
    }
}