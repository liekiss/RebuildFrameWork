using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Domain.BaseModel;
using HY.Domain.Repositories.IRepositories;

namespace HY.Repositories.EntityFramework
{
    public class EfRepositoryContext : IRepositoryContext
    {
        public bool Committed { get; }
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RegisterNew<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot
        {
            throw new NotImplementedException();
        }

        public void RegisterModify<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot
        {
            throw new NotImplementedException();
        }

        public void RegisterDelete<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot
        {
            throw new NotImplementedException();
        }
    }
}
