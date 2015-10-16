using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HY.Domain.Model;

namespace HY.Repositories.EntityFramework.ModelConfigurations
{
    public class SysRoleTypeConfiguration : EntityTypeConfiguration<SysRole>
    {
        public SysRoleTypeConfiguration()
        {
            HasKey(c => c.Pkid);
            Property(c => c.Pkid).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).HasMaxLength(20);
            Property(c => c.Remark).HasMaxLength(100);
        }
    }
}
