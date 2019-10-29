using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuzzTicket.Domain.SharedKernel.Entities
{
    public abstract class BaseEntity<T> where T : class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

    }
}
