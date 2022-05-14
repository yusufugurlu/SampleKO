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
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasOne(x => x.Product).WithMany(p => p.ProductTypes).HasForeignKey(x => x.ProductId).HasConstraintName("FK_Product_ProductTypes_ProductId");

            builder.HasOne(x => x.Color).WithMany(p => p.ProductTypes).HasForeignKey(x => x.ColorId).HasConstraintName("FK_Color_ProductTypes_ColorId");

            builder.HasOne(x => x.Size).WithMany(p => p.ProductTypes).HasForeignKey(x => x.SizeId).HasConstraintName("FK_Size_ProductTypes_SizeId");

            builder.HasData(new ProductType
            {
                Id = 1, 
                Amount=15.0m,
                ColorId=1,
                IsActive=true,
                ProductId=1,
                SizeId=1,
                Stock=12,
                IsDelete=false,
                

            });


            builder.HasData(new ProductType
            {
                Id = 2,
                Amount = 150.0m,
                ColorId = 1,
                IsActive = true,
                ProductId = 2,
                SizeId = 1,
                Stock = 120,
                IsDelete = false,
            });
        }
    }
}
