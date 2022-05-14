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
    internal class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {

            builder.HasData(new Size
            {
                Id = 1,
                SizeName ="xs"
            });

            builder.HasData(new Size
            {
                Id = 2,
                SizeName = "S"
            });

            builder.HasData(new Size
            {
                Id = 3,
                SizeName = "XL"
            });
        }
    }
}
