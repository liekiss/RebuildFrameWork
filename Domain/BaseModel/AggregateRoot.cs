using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BaseModel
{
    public class AggregateRoot : IAggregateRoot
    {
        public long Pkid { get; set; }
        public long AddBy { get; set; }
        public DateTime AddTime { get; set; }
        public long ModifyBy { get; set; }
        public DateTime ModifyTime { get; set; }
    }
}
