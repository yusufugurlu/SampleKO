using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Müşterilerin ürünlerin satış bilgisi entity
    /// </summary>
    public class ProductSale:BaseEntities
    {
        public ProductSale()
        {
            ProductSaleDetails = new HashSet<ProductSaleDetail>();
        }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }
        public virtual IEnumerable<ProductSaleDetail> ProductSaleDetails { get; set; }
    }
}
