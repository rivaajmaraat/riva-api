using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ZAspNetUsers
    {
        public ZAspNetUsers()
        {
            ZAspNetUserClaims = new HashSet<ZAspNetUserClaims>();
            ZAspNetUserLogins = new HashSet<ZAspNetUserLogins>();
            ZAspNetUserRoles = new HashSet<ZAspNetUserRoles>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public byte Level { get; set; }
        public DateTime JoinDate { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<ZAspNetUserClaims> ZAspNetUserClaims { get; set; }
        public virtual ICollection<ZAspNetUserLogins> ZAspNetUserLogins { get; set; }
        public virtual ICollection<ZAspNetUserRoles> ZAspNetUserRoles { get; set; }
    }
}
