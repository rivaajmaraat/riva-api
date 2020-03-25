using System;
using System.Collections.Generic;
using System.Text;

namespace Hayden.Services.ResponseModel
{
    public class AuthResponse
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
