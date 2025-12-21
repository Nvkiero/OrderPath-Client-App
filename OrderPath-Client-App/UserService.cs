using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Metadata;
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

            return "Đăng ký thành công";
        }

        public async Task<LoginResponse?> LoginUser(UserLogin user)
        {
            //MessageBox.Show("BẮT ĐẦU GỌI API");

            var response = await _client.PostAsJsonAsync("auth/login", user);

            MessageBox.Show("ĐÃ NHẬN RESPONSE");

            var raw = await response.Content.ReadAsStringAsync();
            MessageBox.Show(raw == "" ? "RAW RỖNG" : raw);

            if (!response.IsSuccessStatusCode)
                return null;

            return JsonSerializer.Deserialize<LoginResponse>(raw);
        }



    }
}
