using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riva.Api.Models.Responses
{
    public class AuthResponse
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public DateTime Last_Login { get; set; }
    }
}
