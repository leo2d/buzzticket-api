using BuzzTicket.Domain.SharedKernel.Entities;
using BuzzTicket.Domain.SharedKernel.Interfaces;
using BuzzTicket.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BuzzTicket.Infra.Data.Repositories
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : BaseEntity<T>
    {
        protected DataContext _dataContext { get; }

        public BaseRepository(DataContext context)
        {
            _dataContext = context;
        }

        public void Atualizar(T entity)
        {
            _dataContext.Set<T>().Update(entity);
        }

        public async Task<IEnumerable<T>> BuscarPorCondicao(Expression<Func<T, bool>> predicate)
        {
            return await _dataContext.Set<T>()
                .AsNoTracking()
                .Where(predicate)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<T> BuscarPorId(Guid id)
        {
            return await _dataContext.Set<T>()
                 .AsNoTracking()
                 .FirstOrDefaultAsync(e => e.Id == id)
                 .ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> BuscarTodos()
        {
            return await _dataContext.Set<T>()
                 .AsNoTracking()
                 .ToListAsync()
                 .ConfigureAwait(false);
        }

        public async Task Criar(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
        }

        public async Task Excluir(Guid id)
        {
            var entity = await BuscarPorId(id).ConfigureAwait(false);

            _dataContext.Set<T>().Remove(entity);
        }
    }
}