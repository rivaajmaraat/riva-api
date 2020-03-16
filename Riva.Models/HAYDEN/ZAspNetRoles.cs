using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ZAspNetRoles
    {
        public ZAspNetRoles()
        {
            ZAspNetUserRoles = new HashSet<ZAspNetUserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ZAspNetUserRoles> ZAspNetUserRoles { get; set; }
    }
}
