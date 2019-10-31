using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Infra.Data.Config;
using System;
using System.Linq;

namespace BuzzTicket.Api.Configurations
{

    public static class DBInitialize
    {
        public static void Initialize(DataContext context)
        {
            try
            {
                //if (context.Tickets.Any())
                //    return;

                context.Database.EnsureDeleted();

                context.Database.EnsureCreated();

                var tickets = new Ticket[]
                {
                    new Ticket{ Solicitante ="James", Aberto = true, Data = DateTime.Now.AddDays(-5), Solicitacao = "Aumentar memoria do servidor XYZ" },
                    new Ticket{ Solicitante ="Alice", Aberto = false, Data = DateTime.Now.AddMonths(-3), Solicitacao = "Lentidao no portal de reservas" },
                    new Ticket{ Solicitante ="Jack", Aberto = false, Data = DateTime.Now.AddMonths(-5), Solicitacao = "Corrigir bugs no sistema de agendamento" },
                    new Ticket{ Solicitante ="Asuka", Aberto = true, Data = DateTime.Now, Solicitacao = "Melhorar conexao com a internet" },

                    new Ticket{ Solicitante ="Moises", Aberto = false, Data = DateTime.Now.AddDays(-4), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Alice", Aberto = true, Data = DateTime.Now.AddDays(-43), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Bob", Aberto = false, Data = DateTime.Now.AddDays(-12), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Moises", Aberto = true, Data = DateTime.Now, Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Asuka", Aberto = false, Data = DateTime.Now.AddMonths(-6), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Jack", Aberto = true, Data = DateTime.Now.AddDays(-5), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Moises", Aberto = false, Data = DateTime.Now.AddDays(-49), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Bob", Aberto = false, Data = DateTime.Now.AddMonths(-6), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Asuka", Aberto = false, Data = DateTime.Now.AddMonths(-6), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Moises", Aberto = false, Data = DateTime.Now.AddDays(-34), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Jack", Aberto = false, Data = DateTime.Now.AddDays(-25), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Bob", Aberto = false, Data = DateTime.Now.AddDays(-50), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Jack", Aberto = false, Data = DateTime.Now, Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Bob", Aberto = false, Data = DateTime.Now.AddDays(-22), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Moises", Aberto = false, Data = DateTime.Now.AddMonths(-3), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Bob", Aberto = true, Data = DateTime.Now.AddDays(-9), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Asuka", Aberto = true, Data = DateTime.Now.AddDays(-2), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Jack", Aberto = true, Data = DateTime.Now.AddDays(-12), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Alice", Aberto = true, Data = DateTime.Now.AddDays(-20), Solicitacao = "Melhorar conexao com a internet" },
                    new Ticket{ Solicitante ="Bob", Aberto = true, Data = DateTime.Now.AddDays(-7), Solicitacao = "Melhorar conexao com a internet" },
                };

                context.Tickets.AddRange(tickets);

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
