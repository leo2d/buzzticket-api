using BuzzTicket.Domain.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuzzTicket.Domain.TicketAgg.Contracts
{
    public interface ITicketRepository : IRepositoryBase<Ticket>
    {
        Task<IEnumerable<Ticket>> BuscarTicketsOrdenadosPorMaiorData(int quantidade = default);
    }
}
