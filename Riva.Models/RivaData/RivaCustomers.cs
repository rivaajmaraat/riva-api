using System;
using System.Collections.Generic;

namespace Riva.Models.RivaData
{
    public partial class RivaCustomers
    {
        public int CustIdno { get; set; }
        public string CustomerId { get; set; }
        public string StoreNumber { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Comments1 { get; set; }
        public string Comments2 { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShippingMethod { get; set; }
        public short? Salesman { get; set; }
        public short? Terms { get; set; }
        public short? PaymentDiscountTerms { get; set; }
        public float? PaymentDiscountPercent { get; set; }
        public decimal? SalesToDate { get; set; }
        public DateTime? LastSaleDate { get; set; }
        public decimal? LastSaleAmount { get; set; }
        public string Department { get; set; }
        public string SoftwareId { get; set; }
        public string ProductCc { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
