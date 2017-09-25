using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Esfa.Fechoices.Api
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddIfMissing<TService, TImplementation>(
            this IServiceCollection services,
            ServiceLifetime lifetime = ServiceLifetime.Transient)
            where TService : class
            where TImplementation : class, TService
        {
            if (services.All(d => d.ServiceType != typeof(TService)))
            {
                var descriptorToAdd = new ServiceDescriptor(typeof(TService), typeof(TImplementation), lifetime);
                services.Add(descriptorToAdd);
            }
            return services;
        }
    }
}