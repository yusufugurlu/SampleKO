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
    public class ProductCommentConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasOne(x => x.Product).WithMany(p => p.ProductComments).HasForeignKey(x => x.ProductId).HasConstraintName("FK_Product_ProductComments_ProductProductCommentsId");
            builder.HasOne(x => x.Customer).WithMany(p => p.ProductComments).HasForeignKey(x => x.ProductId).HasConstraintName("FK_Customer_ProductComments_CustomerProductCommentsId");
        }
    }
}
