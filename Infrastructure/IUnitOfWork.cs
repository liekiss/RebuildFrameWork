

namespace HY.Infrastructure
{
    public interface IUnitOfWork
    {
        bool Committed { get; }

        void Commit();

        void Rollback();
    }
}
