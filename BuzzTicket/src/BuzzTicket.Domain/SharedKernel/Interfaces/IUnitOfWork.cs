using System;
using System.Threading.Tasks;

namespace BuzzTicket.Domain.SharedKernel.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         Task Commit();
    }
}
