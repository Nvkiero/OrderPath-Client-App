using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Json;


namespace OrderPath_Client_App
{
   public class CustomerServiced
   {
        private readonly HttpClient _client;
        public CustomerServiced()
        {
            _client = ApiClient.Client;
        }
        public async Task<List<CustomerProductDTO>?> GetProducts()
        {
            var res = await _client.GetAsync("customer/products");
            if (!res.IsSuccessStatusCode) return null;

            return await res.Content.ReadFromJsonAsync<List<CustomerProductDTO>>();
        }

        public async Task<List<CustomerProductDTO>?> SearchProduct(string name)
        {
            var res = await _client.GetAsync($"customer/products/search?name={name}");
            if (!res.IsSuccessStatusCode) return null;

            return await res.Content.ReadFromJsonAsync<List<CustomerProductDTO>>();
        }

    }
}
