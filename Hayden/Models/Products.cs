using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class Products
    {
        public Products()
        {
            ProductsBom = new HashSet<ProductsBom>();
            ProductsPrices = new HashSet<ProductsPrices>();
            ProductsStock = new HashSet<ProductsStock>();
            ProductsWtg = new HashSet<ProductsWtg>();
        }

        public int ProductsId { get; set; }
        public string ProductName { get; set; }
        public string Sku { get; set; }
        public string CustomerSku { get; set; }
        public bool ProductFlag { get; set; }
        public string ProductDesc { get; set; }
        public string CustomerCode { get; set; }
        public string CommentBox { get; set; }
        public int Status { get; set; }
        public string PicPath { get; set; }
        public int? JewelryType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FirstProductionDate { get; set; }

        public virtual ICollection<ProductsBom> ProductsBom { get; set; }
        public virtual ICollection<ProductsPrices> ProductsPrices { get; set; }
        public virtual ICollection<ProductsStock> ProductsStock { get; set; }
        public virtual ICollection<ProductsWtg> ProductsWtg { get; set; }
    }
}
