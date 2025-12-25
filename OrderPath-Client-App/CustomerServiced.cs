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

        public async Task<List<CartItemDTO>> GetCartAsync()
        {
            var response = await _client.GetAsync("customer/cart");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<CartItemDTO>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();
        }

        public async Task<bool> RemoveFromCartAsync(int productId)
        {
            var response = await _client.DeleteAsync($"customer/cart/remove/{productId}");
            return response.IsSuccessStatusCode;
        }

        public  async Task<bool> CheckoutAsync()
        {
            var response = await _client.PostAsync("customer/order/checkout", null);
            return response.IsSuccessStatusCode;
        }

        public  async Task<List<OrderDTO>> GetMyOrders()
        {

            var response = await _client.GetAsync("customer/order/my");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var orders = JsonSerializer.Deserialize<List<OrderDTO>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return orders ?? new List<OrderDTO>();
        }

        public  async Task<OrderDetailDTO> GetOrderDetail(int orderId)
        {
            var response = await _client.GetAsync($"customer/order/{orderId}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var order = JsonSerializer.Deserialize<OrderDetailDTO>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return order!;
        }
    }
}

