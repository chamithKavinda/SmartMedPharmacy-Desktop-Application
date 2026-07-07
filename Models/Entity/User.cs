using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMedPharmacy.Models
{
    public class User
    {
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
