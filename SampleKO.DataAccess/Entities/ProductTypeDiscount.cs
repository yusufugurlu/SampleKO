using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Ürünlerin Özelliklerine Göre İndirim sağlandığı entity
    /// </summary>
    public class ProductTypeDiscount:BaseEntities
    {
        public decimal DiscountAmount { get; set; }
        public bool IsActive { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
