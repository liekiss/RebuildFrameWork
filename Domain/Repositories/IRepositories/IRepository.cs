using System;
using System.Collections.Generic;
using System.Linq;
using HY.Domain.BaseModel;

namespace HY.Domain.Repositories.IRepositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class, IAggregateRoot
    {
        IEnumerable<TEntity> Get();

        IEnumerable<TEntity> GetByCondition(Func<TEntity, bool> expression);

        TEntity GetById(long pkid);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
