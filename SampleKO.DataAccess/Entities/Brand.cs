using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Marka Entity
    /// </summary>
    public class Brand:BaseEntities
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }
        public string BrandFullName { get; set; }
        public string BrandShortName { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
