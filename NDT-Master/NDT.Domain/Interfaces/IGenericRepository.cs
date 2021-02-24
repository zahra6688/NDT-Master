using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NDT.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(object id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(object id);

        Task Delete(TEntity entity);

        //IQueryable<T> GetAllNoTracking { get; }
        //IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includedProperties);
        //IQueryable<T> GetAllIncluding(string includedProperties);

    }
}
