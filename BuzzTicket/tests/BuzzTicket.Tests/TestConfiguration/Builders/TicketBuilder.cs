using Bogus;
using BuzzTicket.Domain.TicketAgg;
using System;
using System.Collections.Generic;

namespace BuzzTicket.Tests.TestConfiguration.Builders
{
    public class TicketBuilder
    {
        public static Ticket Build()
        {
            var ticket = new Faker<Ticket>()
                .RuleFor(h => h.Solicitante, fh => fh.Name.FirstName())
                .RuleFor(h => h.Solicitacao, fh => fh.Lorem.Text())
                .RuleFor(h => h.Data, fh => fh.Date.Between(DateTime.Now.AddYears(-1), DateTime.Now))
                .RuleFor(h => h.Id, fh => fh.Random.Guid())
                .RuleFor(h => h.Aberto, fh => fh.Random.Bool());

            return ticket.Generate();
        }

        public static IEnumerable<Ticket> Build(int quantity)
        {
            var tickets = new List<Ticket>();

            for (int i = 0; i < quantity; i++)
            {
                tickets.Add(Build());
            }

            return tickets;
        }
    }
}
