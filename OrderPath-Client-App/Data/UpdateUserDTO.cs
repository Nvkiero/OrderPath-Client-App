using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public class UpdateUserDTO
    {
        public string Fullname { get; set; } = "";
        public DateTime Birth { get; set; }
        public int Age { get; set; }
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; }
    }
}
