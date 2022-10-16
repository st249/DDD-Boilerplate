using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Base;

namespace Template.Domain.Interfaces
{
    public interface IQueryService
    {

    }

    public interface IQueryService<TEntity, TKey> : IQueryService
        where TEntity : class, IAggregateRoot<TKey>
    {
        Task<TEntity> GetAsync(TKey id);
        Task<TEntity> FindAsync(TKey id);
        Task<List<TEntity>> GetAllAsync();
        Task<IQueryable<TEntity>> GetQueryableAsync([NotNull] Expression<Func<TEntity, bool>> predicate);
    }
}
