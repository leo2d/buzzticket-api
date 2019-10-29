using AutoMapper;
using BuzzTicket.Api.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BuzzTicket.Api.Configurations
{
    public static class MapperInitialize
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(x =>
            {
                x.AddProfile(new ViewModelToDomainProfile());
                x.AllowNullCollections = true;
                x.AllowNullDestinationValues = true;
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
