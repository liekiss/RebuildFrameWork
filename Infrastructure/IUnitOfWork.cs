using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IUnitOfWork
    {
        bool Committed { get; }

        void Commit();

        void Rollback();
    }
}
