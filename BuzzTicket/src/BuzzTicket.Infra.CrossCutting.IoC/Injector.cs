using BuzzTicket.Domain.SharedKernel.Interfaces;
using BuzzTicket.Domain.TicketAgg.Contracts;
using BuzzTicket.Domain.TicketAgg.Services;
using BuzzTicket.Infra.Data.Config;
using BuzzTicket.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuzzTicket.Infra.CrossCutting.IoC
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            RegisterContexts(services, configuration);

            services.AddScoped<DataContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ITicketRepository, TicketRepository>();
        }

        private static void RegisterContexts(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:MySql"];
            services.AddDbContext<DataContext>(options =>
                    options.UseMySql(connectionString));
        }
    }
}
