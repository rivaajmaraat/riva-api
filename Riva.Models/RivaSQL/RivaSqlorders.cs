using System;
using System.Collections.Generic;

namespace Riva.Models.RivaSQL
{
    public partial class RivaSqlorders
    {
        public int OrderId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Company { get; set; }
        public string StoreNumber { get; set; }
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public string CustomerOrderNo { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipVia { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? OriginalReqDateRo { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }
        public string InvoiceComments { get; set; }
        public string OrderSource { get; set; }
        public DateTime? GoldDate { get; set; }
        public decimal? GoldPrice { get; set; }
        public byte OrderType { get; set; }
        public bool? Closed { get; set; }
        public int? Boxlink { get; set; }
        public int? Uapoid { get; set; }
        public string Uadyso { get; set; }
        public string SoftwareId { get; set; }
        public int? DeptNo { get; set; }
        public int? Terms { get; set; }
    }
}
