using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Domain.TicketAgg.Contracts;
using BuzzTicket.Domain.TicketAgg.Services;
using Moq;
using System.Collections.Generic;

namespace BuzzTicket.Tests.TestConfiguration.Mocks
{
    public class TicketServiceMock : CustomMock<TicketService>
    {
        public override CustomMock<TicketService> UseDefaultMock()
        {
            return this;
        }

        public TicketServiceMock MockBuscarTicketsOrdenadosPorMaiorData(IEnumerable<Ticket> tickets, int quantidade)
        {
            _mocker.GetMock<ITicketRepository>()
                   .Setup(x => x.BuscarTicketsOrdenadosPorMaiorData(quantidade))
                   .ReturnsAsync(tickets);

            return this;
        }
    }
}
