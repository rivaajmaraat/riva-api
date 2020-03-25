using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
        public int Status { get; set; }
    }
}
