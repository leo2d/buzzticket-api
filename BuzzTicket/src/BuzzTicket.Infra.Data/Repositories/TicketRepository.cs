using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Domain.TicketAgg.Contracts;
using BuzzTicket.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzTicket.Infra.Data.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IEnumerable<Ticket>> BuscarTicketsOrdenadosPorMaiorData(int quantidade = 0)
        {
            var query = _dataContext.Tickets.AsQueryable().OrderByDescending(x => x.Data);

            var resultado = quantidade > 0 ? query.Take(quantidade) : query;

            return await resultado.ToListAsync().ConfigureAwait(false);
        }
    }
}
