using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public class Users
    {
        private string Username { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        private string Fullname { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
        private DateTime Birth { get; set; }
        private string Phone { get; set; } = string.Empty;
        private int Age { get; set; }
        private string Addresss { get; set; } = string.Empty;
    }
}
