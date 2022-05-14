using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    public class Color:BaseEntities
    {
        public Color()
        {
            ProductTypes = new HashSet<ProductType>();
        }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
