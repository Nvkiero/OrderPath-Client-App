using OrderPath_Client_App.Data;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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

        //Helper: Hàm này để gắn Token vào mỗi request
        private void SetToken(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }

         //1. GET: Lấy thông tin cá nhân(Cần Token)
        public async Task<UserResponse?> GetMyProfile(string token)
        {
            SetToken(token); // Gắn token

            // Gọi đúng endpoint server: users/profile
            var res = await _client.GetAsync("users/profile");

            if (!res.IsSuccessStatusCode) return null;

            var json = await res.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<UserResponse>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        // 2. PUT: Cập nhật thông tin (Cần Token)
         public async Task<bool> UpdateProfile(string token, UpdateUserDTO dto)
         {
             SetToken(token); // Gắn token

             // Gọi đúng endpoint server: users/me (không cần truyền ID vì server tự lấy từ token)
             var res = await _client.PutAsJsonAsync("users/me", dto);
             return res.IsSuccessStatusCode;
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

        //Gửi OTP đến email người dùng
        public async Task<bool> SendOtpAsync(string email)
        {
            var res = await _client.PostAsJsonAsync("auth/send-otp", new SendOtpRequest { Email = email }
            );
            return res.IsSuccessStatusCode;
        }
        public async Task<string> ForgotPasswordAsync(ForgotPassword model)
        {
            var res = await _client.PostAsJsonAsync("auth/forgot-password", model);
            var json = await res.Content.ReadAsStringAsync();

            return JsonDocument.Parse(json)
                .RootElement.GetProperty("message").GetString()!;
        }
        // Đổi mật khẩu cho người dùng đã đăng nhập
        public async Task<string> ChangePasswordAsync(ChangePassword model, string token)
        {
            SetToken(token);

            var res = await _client.PutAsJsonAsync("auth/change-password", model);
            var json = await res.Content.ReadAsStringAsync();

            return JsonDocument.Parse(json)
                .RootElement.GetProperty("message").GetString()!;
        }

        public async Task<UserResponse?> GetUserById() //get thong tin user
        {
            var res = await _client.GetAsync($"users/profile");
            MessageBox.Show(res.ToString());
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
    

