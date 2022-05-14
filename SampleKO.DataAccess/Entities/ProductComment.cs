using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Ürünlere Yorum Yapılacağı Entity
    /// </summary>
    public class ProductComment:BaseEntities
    {
        public string Comment { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
