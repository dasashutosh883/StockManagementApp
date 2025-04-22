using SMA.Infrastructure.Data.Factory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SMA.Infrastructure.Extensions
{
    public static class InfraService
    {
        public static void AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConnectionFactory>(
                new ConnectionFactory(configuration.GetConnectionString("DbConnection")!));

            //services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            //services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
        }
    }
}