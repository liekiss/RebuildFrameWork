using System;
using HY.Domain.BaseModel;
using HY.Infrastructure;

namespace HY.Domain.Repositories.IRepositories
{
    public interface IRepositoryContext : IUnitOfWork, IDisposable
    {
        void RegisterNew<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot;

        void RegisterModify<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot;

        void RegisterDelete<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot;
    }
}
