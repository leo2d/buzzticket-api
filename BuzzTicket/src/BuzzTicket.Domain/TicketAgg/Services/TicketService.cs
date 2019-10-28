using BuzzTicket.Domain.TicketAgg.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuzzTicket.Domain.TicketAgg.Services
{
    public class TicketService : ITicketService
    {
        public Task AtualizarTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> BuscarTicket(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> BuscarTickets()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> BuscarTickets(int quantidade)
        {
            throw new NotImplementedException();
        }

        public Task CriarTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirTicket(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
