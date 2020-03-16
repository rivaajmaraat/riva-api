using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ZAspNetUserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public virtual ZAspNetUsers User { get; set; }
    }
}
