using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuzzTicket.Domain.TicketAgg.Contracts
{
    public interface ITicketService
    {
        Task CriarTicket(Ticket ticket);
        Task AtualizarTicket(Ticket ticket);
        Task ExcluirTicket(Guid Id);
        Task<Ticket> BuscarTicket(Guid id);
        Task<IEnumerable<Ticket>> BuscarTickets();
        Task<IEnumerable<Ticket>> BuscarTickets(int quantidade);
    }
}
