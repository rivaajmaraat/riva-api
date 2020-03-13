using System;
using System.Collections.Generic;

namespace Riva.Models.Models
{
    public partial class OrdersTry
    {
        public int OrderId { get; set; }
        public int OrderStateId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime CustomerOrderDate { get; set; }
        public string CustomerId { get; set; }
        public string CustomerOrderNo { get; set; }
        public string ShipCompanyName { get; set; }
        public string ShipPerson { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipVia { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string OrderSource { get; set; }
        public decimal? RawPrice { get; set; }
        public string TrackingNumber { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual OrderStates OrderState { get; set; }
    }
}
