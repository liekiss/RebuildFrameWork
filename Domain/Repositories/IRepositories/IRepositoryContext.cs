using System;
using Infrastructure;

namespace Domain.Repositories.IRepositories
{
    public interface IRepositoryContext : IUnitOfWork, IDisposable
    {
        void RegisterNew<TAggregateRoot>(TAggregateRoot entity);

        void RegisterModify<TAggregateRoot>(TAggregateRoot entity);

        void RegisterDelete<TAggregateRoot>(TAggregateRoot entity);
    }
}
