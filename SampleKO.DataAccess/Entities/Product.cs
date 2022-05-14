using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Ürün entity
    /// </summary>
    public class Product:BaseEntities
    {
        public Product()
        {
            ProductComments = new HashSet<ProductComment>();
            ProductTypes = new HashSet<ProductType>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public virtual IEnumerable<ProductComment> ProductComments { get; set; } 
        public virtual IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
