using BuzzTicket.Domain.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BuzzTicket.Domain.SharedKernel.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity<T>
    {
        Task Criar(T entity);
        Task Atualizar(T entity);
        Task Excluir(Guid id);
        Task<T> BuscarPorId(Guid id);
        Task<IEnumerable<T>> BuscarTodos();
        Task<IEnumerable<T>> BuscarPorCondicao(Expression<Func<T, bool>> predicate);
    }
}
