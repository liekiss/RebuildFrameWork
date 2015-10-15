using System;

namespace HY.Domain.BaseModel
{
    public interface IAggregateRoot : IEntity
    {
        long AddBy { get; set; }

        DateTime AddTime { get; set; }

        long ModifyBy { get; set; }

        DateTime ModifyTime { get; set; }
    }
}
