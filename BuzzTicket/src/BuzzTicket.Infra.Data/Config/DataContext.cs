using BuzzTicket.Domain.TicketAgg;
using BuzzTicket.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        public override int SaveChanges()
        {
            SetId();

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetId();

            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        private void SetId()
        {
            var added = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added).Select(x => x.Entity);

            foreach (var entry in added)
            {
                if (entry.GetType().GetProperty("Id") != null)
                    entry.GetType().GetProperty("Id").SetValue(entry, Guid.NewGuid());
            }
        }
    }
}
