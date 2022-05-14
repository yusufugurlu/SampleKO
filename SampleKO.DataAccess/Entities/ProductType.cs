using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Ürünlerin Özelliklerine göre bilgilerin getirildiği entity
    /// </summary>
    public class ProductType : BaseEntities
    {
        public ProductType()
        {
            ProductTypeDiscounts = new HashSet<ProductTypeDiscount>();
            ProductSaleDetails = new HashSet<ProductSaleDetail>();
        }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int SizeId { get; set; }
        public int Stock { get; set; }
        public Size Size { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
        public virtual IEnumerable<ProductTypeDiscount> ProductTypeDiscounts { get; set; }
        public virtual IEnumerable<ProductSaleDetail> ProductSaleDetails { get; set; }
    }
}
