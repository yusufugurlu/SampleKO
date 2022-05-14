using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.DataAccess.Entities
{
    /// <summary>
    /// Müşterilerin satıın aldıkları ürünlerin detay tablosu
    /// </summary>
    public class ProductSaleDetail:BaseEntities
    {
        public int ProductTypeSaleId { get; set; }
        public ProductSale ProductSale { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int Unit { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
