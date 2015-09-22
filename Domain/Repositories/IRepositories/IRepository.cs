using System;
using System.Linq;
using Domain.BaseModel;

namespace Domain.Repositories.IRepositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class, IAggregateRoot
    {
        IQueryable<TEntity> Get();

        IQueryable<TEntity> GetByCondition(Func<TEntity, bool> expression);

        TEntity GetById(long pkid);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
