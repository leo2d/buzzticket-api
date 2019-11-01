using BuzzTicket.Domain.SharedKernel.Entities;
using System;

namespace BuzzTicket.Domain.TicketAgg
{
    public class Ticket : BaseEntity<Ticket>
    {
        public string Solicitante { get; set; }
        public DateTime Data { get; set; }
        public bool Aberto { get; set; }
        public string Solicitacao { get; set; }

    }
}
