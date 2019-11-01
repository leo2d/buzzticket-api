using AutoMapper;
using BuzzTicket.Api.ViewModels;
using BuzzTicket.Domain.TicketAgg;

namespace BuzzTicket.Api.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<TicketViewModel, Ticket>().ReverseMap();
        }
    }
}
