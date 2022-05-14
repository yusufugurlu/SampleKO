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
    public class ColorConfiuration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {

            builder.HasData(new Color
            {
                Id = 1,
                ColorName = "Kırmızı",
                Description = ""
            });

            builder.HasData(new Color
            {
                Id = 2,
                ColorName = "Yeşil",
                Description = ""
            });

            builder.HasData(new Color
            {
                Id = 3,
                ColorName = "Mavi",
                Description = ""
            });
        }
    }
}
