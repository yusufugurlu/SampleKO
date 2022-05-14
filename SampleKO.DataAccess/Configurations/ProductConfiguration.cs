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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Brand).WithMany(p => p.Products).HasForeignKey(x => x.BrandId).HasConstraintName("FK_Brand_Products_BrandId");


            builder.HasData(new Product
            {
                Id = 1,
                BrandId=1,
                Description="",
                Name="Lc-walkiki pantalon",
                
            });


            builder.HasData(new Product
            {
                Id = 2,
                BrandId = 2,
                Description = "",
                Name = "Defacto pantalon",
            });

        }
    }
}
