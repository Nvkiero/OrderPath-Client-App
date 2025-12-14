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

        public async Task<bool> RegisterUser(UserRegister user)
        {
            var response = await _client.PostAsJsonAsync("auth/register", user);

            return response.IsSuccessStatusCode;
        }
    }
}
