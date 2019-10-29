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
            services.AddDbContext<DataContext>(options =>
                    options.UseMySQL(configuration.GetConnectionString("ConnectionStrings:MySql")));

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ITicketRepository, TicketRepository>();
        }
    }
}
