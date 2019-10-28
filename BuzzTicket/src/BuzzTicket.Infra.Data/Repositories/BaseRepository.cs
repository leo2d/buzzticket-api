using BuzzTicket.Domain.SharedKernel.Entities;
using BuzzTicket.Domain.SharedKernel.Interfaces;
using BuzzTicket.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BuzzTicket.Infra.Data.Repositories
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : BaseEntity<T>
    {
        protected DataContext _dataContext;

        public BaseRepository(DataContext context)
        {
            _dataContext = context;
        }

        public async Task Atualizar(T entity)
        {
             _dataContext.Update(entity);
        }

        public async Task<IEnumerable<T>> BuscarPorCondicao(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<T> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Criar(T entity)
        {
            await _dataContext.AddAsync(entity);
        }

        public async Task Excluir(Guid id)
        {
            var entity = await BuscarPorId(id);
            _dataContext.Remove(entity);
        }
    }
}