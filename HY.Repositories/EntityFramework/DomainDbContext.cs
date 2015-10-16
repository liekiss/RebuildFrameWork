using System.Data.Entity;
using HY.Domain.Model;
using HY.Repositories.EntityFramework.ModelConfigurations;

namespace HY.Repositories.EntityFramework
{
    public class DomainDbContext : DbContext
    {
        public DomainDbContext()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        #region 实体属性

        public DbSet<SysRole> SysRoles { get; set; }

        public DbSet<SysUser> SysUsers { get; set; }

        public DbSet<SysUserRole> SysUserRoles { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Configurations
                .Add(new SysRoleTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
