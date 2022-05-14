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
    internal class CustomerConfiguraton : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(x => x.Role).WithMany(p => p.Customers).HasForeignKey(x => x.RoleId).HasConstraintName("FK_Customer_Role_CustomerRoleId");

            builder.HasData(new Customer
            {
                Id = 1,
                Email = "admin@admin.com",
                IsDelete = false,
                Name = "admin",
                Password = "123",
                RoleId = 1,
                SurName = "admin",
                TcNo = "12345678901"
            });
        }
    }
}
