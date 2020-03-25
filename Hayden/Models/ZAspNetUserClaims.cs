using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class ZAspNetUserClaims
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual ZAspNetUsers User { get; set; }
    }
}
