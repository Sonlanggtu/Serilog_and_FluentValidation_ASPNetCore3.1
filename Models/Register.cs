using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationASPNET.Models
{
    public class Register
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Xa { get; set; }
        public string City { get; set; }
        public string Quan { get; set; }
        public string PostCode { get; set; }
        public string Check { get; set; }
    }
}
