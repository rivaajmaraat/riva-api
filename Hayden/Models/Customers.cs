﻿using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class Customers
    {
        public int CustIdno { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string EmailAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ShippingMethod { get; set; }
    }
}
