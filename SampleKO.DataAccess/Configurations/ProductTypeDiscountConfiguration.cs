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
    public class ProductTypeDiscountConfiguration : IEntityTypeConfiguration<ProductTypeDiscount>
    {
        public void Configure(EntityTypeBuilder<ProductTypeDiscount> builder)
        {
            builder.HasOne(x => x.ProductType).WithMany(p => p.ProductTypeDiscounts).HasForeignKey(x => x.ProductTypeId).HasConstraintName("FK_ProductType_ProductTypeDiscounts_ProductTypeId");
        }
    }
}
