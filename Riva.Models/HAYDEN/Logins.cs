using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class Logins
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
        public int Status { get; set; }
    }
}
