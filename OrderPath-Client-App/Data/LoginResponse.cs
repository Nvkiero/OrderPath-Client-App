using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    using System.Text.Json.Serialization;

    public class LoginResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }


}
