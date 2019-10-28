using System;

namespace BuzzTicket.Domain.SharedKernel.Entities
{
    public abstract class BaseEntity<T> where T : class
    {
        public Guid Id { get; set; }

    }
}
