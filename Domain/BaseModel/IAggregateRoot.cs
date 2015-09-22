using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BaseModel
{
    public interface IAggregateRoot : IEntity
    {
        long AddBy { get; set; }

        DateTime AddTime { get; set; }

        long ModifyBy { get; set; }

        DateTime ModifyTime { get; set; }
    }
}
