using System.Collections.Generic;
using HY.Domain.BaseModel;

namespace HY.Domain.Model
{
    public class SysUser : AggregateRoot
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<SysUserRole> SysUserRoles { get; set; }
    }
}
