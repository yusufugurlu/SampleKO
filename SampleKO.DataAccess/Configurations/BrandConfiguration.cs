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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {

            builder.HasData(new Brand
            {
                Id = 1, 
                Description="",
                BrandFullName="LC walkiki",
                BrandShortName= "LC walkiki",
                IsDelete=false
            });


            builder.HasData(new Brand
            {
                Id = 2,
                Description = "",
                BrandFullName = "Facto",
                BrandShortName = "Facto",
                IsDelete = false
            });
        }
    }
}
