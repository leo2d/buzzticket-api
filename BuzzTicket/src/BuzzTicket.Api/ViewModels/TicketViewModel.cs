using System;
using System.ComponentModel.DataAnnotations;

namespace BuzzTicket.Api.ViewModels
{
    public class TicketViewModel
    {
        public Guid? Id { get; set; }
        public bool Aberto { get; set; }

        [Required]
        [MaxLength(255)]
        public string Solicitante { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [MaxLength(1000)]
        public string Solicitacao { get; set; }
    }
}
