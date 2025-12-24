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

        public async Task<RegisterResponse?> RegisterUser(UserRegister user)
        {
            var response = await _client.PostAsJsonAsync("auth/register", user);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(
                    JsonDocument.Parse(json).RootElement.GetProperty("message").GetString()
                );

            return JsonSerializer.Deserialize<RegisterResponse>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        public async Task<LoginResponse?> LoginUser(UserLogin user)
        {
            var response = await _client.PostAsJsonAsync("auth/login", user);
            var raw = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(
                    JsonDocument.Parse(raw).RootElement.GetProperty("message").GetString()
                );

            return JsonSerializer.Deserialize<LoginResponse>(
                raw,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        // Gửi OTP đến email người dùng
        public async Task<bool> SendOtpAsync(string email)
        {
            var response = await _client.PostAsJsonAsync("auth/send-otp", email);
            return response.IsSuccessStatusCode;
        }
        // Xác nhận OTP và đặt lại mật khẩu
        public async Task<string> ForgotPasswordAsync(ForgotPassword model)
        {
            var response = await _client.PostAsJsonAsync("auth/forgot-password", model);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return json;

            using var doc = JsonDocument.Parse(json);
            return doc.RootElement.GetProperty("message").GetString()!;
        }
        // Đổi mật khẩu cho người dùng đã đăng nhập
        public async Task<string> ChangePasswordAsync(ChangePassword model,string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _client.PutAsJsonAsync("auth/change-password", model);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return json;

            using var doc = JsonDocument.Parse(json);
            return doc.RootElement.GetProperty("message").GetString()!;
        }
        public async Task<UserResponse?> GetUserById(int userId) //get thong tin user
        {
            var res = await _client.GetAsync($"users/{userId}");

            if (!res.IsSuccessStatusCode)
                return null;

            var json = await res.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<UserResponse>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
        public async Task<bool> UpdateProfile(int userId, UpdateUserDTO dto) //cap nhap thong tin user 
        {
            var res = await _client.PutAsJsonAsync($"users/{userId}", dto);
            return res.IsSuccessStatusCode;
        }
    }
}
    

