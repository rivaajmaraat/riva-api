using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ZAspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual ZAspNetRoles Role { get; set; }
        public virtual ZAspNetUsers User { get; set; }
    }
}
