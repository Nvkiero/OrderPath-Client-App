using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OrderPath_Client_App.Data
{
    public static class ApiClient
    {
        public static HttpClient Client { get; }

        static ApiClient()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:5000/");
        }
    }
}
