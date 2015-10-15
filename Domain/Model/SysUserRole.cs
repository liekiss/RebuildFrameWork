using System.Security.AccessControl;
using HY.Domain.BaseModel;

namespace HY.Domain.Model
{
    public class SysUserRole : AggregateRoot
    {
        public long SysRoleId { get; set; }

        public long SysUserId { get; set; }

        public virtual SysRole SysRole { get; set; }

        public virtual SysUser SysUser { get; set; }
    }
}
