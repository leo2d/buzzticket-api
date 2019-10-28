using BuzzTicket.Domain.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BuzzTicket.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _context { get; }

        public UnitOfWork(DbContext Context)
        {
            _context = Context;
        }

        public async Task Commit()
        {
           await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
