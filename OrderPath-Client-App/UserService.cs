using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrderPath_Client_App
{
    public class UserService
    {
        private readonly HttpClient _client;

        public UserService()
        {
            _client = ApiClient.Client;
        }

        public async Task<string> RegisterUser(UserRegister user)
        {
            var response = await _client.PostAsJsonAsync("auth/register", user);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return "Đăng ký thất bại";

            using var doc = JsonDocument.Parse(json);
            return doc.RootElement.GetProperty("message").GetString()!;
        }

        public async Task<string> LoginUser(UserLogin user)
        {
            var response = await _client.PostAsJsonAsync("auth/login", user);
            var json = await response.Content.ReadAsStringAsync();

            // DEBUG (bạn có thể xóa sau)
            MessageBox.Show(json);

            if (!response.IsSuccessStatusCode)
            {
                return json; // trả thẳng message string
            }
            using var doc = JsonDocument.Parse(json);

            return doc.RootElement
                      .GetProperty("accessToken")
                      .GetString()!;
        }


    }
}
