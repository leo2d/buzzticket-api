using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

namespace BuzzTicket.Infra.Data.Config
{
    public class DataContext : DbContext
    {

        public DbSet<Ticket> Tickets { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null) throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new TicketMap());
        }
    }
}
