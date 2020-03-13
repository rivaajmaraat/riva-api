using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ProductsTry
    {
        public int ProductId { get; set; }
        public string CustomerSku { get; set; }
        public string InternalSku { get; set; }
        public string ProductName { get; set; }
        public string PicturePath { get; set; }
        public string CommentsRouting { get; set; }
        public string CommentsPd { get; set; }
        public decimal? UnitPrice { get; set; }
        public int ProductTypeId { get; set; }
        public bool Customizeable { get; set; }
        public bool CustomCast { get; set; }
        public string Size { get; set; }
        public int? UnitsStock { get; set; }
        public int? UnitsShipped { get; set; }
        public int? UnitsOrders { get; set; }
        public int? UnitsProduction { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateEditted { get; set; }
        public string UpdatedBy { get; set; }
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
    }
}
