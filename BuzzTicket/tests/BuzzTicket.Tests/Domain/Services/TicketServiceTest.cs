using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Tests.TestConfiguration.Builders;
using BuzzTicket.Tests.TestConfiguration.Mocks;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BuzzTicket.Tests.Domain.Services
{
    public class TicketServiceTest
    {

        private TicketServiceMock _serviceMock;

        public TicketServiceTest()
        {
            _serviceMock = new TicketServiceMock();
        }

        [Theory(DisplayName = "Buscar Tickets Ordenados Por Maior Data - Suscesso ")]
        [MemberData(nameof(TestData))]
        public async Task BuscarTicketsOrdenadosPorMaiorDataSuscesso(IEnumerable<Ticket> tickets, int quantidade)
        {
            #region Given

            var service = _serviceMock
                .MockBuscarTicketsOrdenadosPorMaiorData(tickets: tickets, quantidade: quantidade)
                .Resolve();

            #endregion

            #region When

            var result = await service.BuscarTicketsOrdenadosPorMaiorData(quantidade);

            #endregion

            #region Then

            result.Should().NotBeEmpty();
            result.Should().HaveCount(quantidade);
            result.Should().NotBeNull();

            #endregion
        }

        [Fact(DisplayName = "Buscar Tickets Ordenados Por Maior Data - Numero Negativo ")]
        public async Task BuscarTicketsOrdenadosPorMaiorDataErroNumeroNegativo()
        {
            int quantidade = -1;
            var tickets = TicketBuilder.Build(1);

            #region Given

            var service = _serviceMock
                .MockBuscarTicketsOrdenadosPorMaiorData(tickets: tickets, quantidade: quantidade)
                .Resolve();

            #endregion

            #region When

            Func<Task> action = async () => await service.BuscarTicketsOrdenadosPorMaiorData(quantidade);

            #endregion

            #region Then

            await action.Should().ThrowAsync<ArgumentOutOfRangeException>();

            #endregion
        }

        public static IEnumerable<object[]> TestData => new List<object[]>()
        {
            new object[]
            {
               TicketBuilder.Build(1) , 1
            },
            new object[]
            {
                TicketBuilder.Build(2), 2
            },
            new object[]
            {
                TicketBuilder.Build(20), 20
            },
        };


    }
}
