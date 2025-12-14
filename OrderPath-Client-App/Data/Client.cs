using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public static class ApiClient
    {
        public static readonly HttpClient Client = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5000/api/")
        };
    }
}
