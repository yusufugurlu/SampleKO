using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    public class Size : BaseEntities
    {
        public Size()
        {
            ProductTypes = new HashSet<ProductType>();
        }
        public string SizeName { get; set; }
        public virtual IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
