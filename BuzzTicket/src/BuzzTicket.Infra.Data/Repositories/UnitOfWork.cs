using BuzzTicket.Domain.SharedKernel.Interfaces;
using BuzzTicket.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BuzzTicket.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        DataContext _context { get; }

        public UnitOfWork(DataContext Context)
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
