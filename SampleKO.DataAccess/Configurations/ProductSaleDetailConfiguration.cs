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
    public class ProductSaleDetailConfiguration : IEntityTypeConfiguration<ProductSaleDetail>
    {
        public void Configure(EntityTypeBuilder<ProductSaleDetail> builder)
        {
            builder.HasOne(x => x.ProductSale).WithMany(p => p.ProductSaleDetails).HasForeignKey(x => x.ProductTypeSaleId).HasConstraintName("FK_ProductSale_ProductSaleDetails_ProductSaleId");
            builder.HasOne(x => x.ProductType).WithMany(p => p.ProductSaleDetails).HasForeignKey(x => x.ProductTypeId).HasConstraintName("FK_ProductType_ProductSaleDetails_ProductTypeId");
        }
    }
}
