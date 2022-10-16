using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IRepository : IQueryService
    {

    }
    public interface IRepository<TEntity, TKey> : IQueryService<TEntity, TKey>
        where TEntity : class, IAggregateRoot<TKey>
    {

        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);


    }


}
