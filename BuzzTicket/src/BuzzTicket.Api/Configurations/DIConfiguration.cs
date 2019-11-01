using BuzzTicket.Infra.CrossCutting.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuzzTicket.Api.Configurations
{
    public static class DIConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            Injector.RegisterServices(services: services, configuration: configuration);
        }
    }
}
