using System;
using System.Collections.Generic;
using System.Text;

namespace Hayden.Services.RequestModel
{
    public class LoginRequest
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
