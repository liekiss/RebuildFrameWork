using System;
using System.Collections.Generic;
using HY.Domain.BaseModel;

namespace HY.Domain.Model
{
    public class SysRole : AggregateRoot
    {
        public string Name { get; set; }

        public string Remark { get; set; }

        public List<SysUserRole> SysUserRoles { get; set; }
    }
}
