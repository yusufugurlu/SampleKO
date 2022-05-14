using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleKO.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role
            {
                Id = 1,
            RoleName = "SysAdmin"
            });

            builder.HasData(new Role
            {
                Id = 2,
                RoleName = "Admin"
            });

            builder.HasData(new Role
            {
                Id = 3,
                RoleName = "Customer"
            });
        }
    }
}
