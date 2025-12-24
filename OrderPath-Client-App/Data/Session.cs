using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public static class Session
    {
        public static string Token { get; set; } = "";
        public static int UserId { get; set; }
        public static string Role { get; set; } = "";
        public static string Username { get; set; } = "";
    }
}
