using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Persistence.Repository;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IServicesRepository, ServiceRepository >();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
