using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderPath_Client_App.Forms;
using System.Net.Http;
using System.Text.Json;
using OrderPath_Client_App.Data;
namespace OrderPath_Client_App
{
    public partial class InforUsers : Form
    {
        private int userId = 1; // TODO: lấy từ Login
        private string baseUrl = "https://localhost:5275/"; // TODO: đổi port
        private string imagePath = "";
         
        public InforUsers()
        {
            InitializeComponent();
        }

        private void pB_AnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pB_AnhDaiDien.Image = Image.FromFile(imagePath);
                pB_AnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private async void bt_thayDoiThongTin_Click(object sender, EventArgs e)
        {
            await UploadAvatar();
            FormUpdateInfor formUpdateInfor = new FormUpdateInfor();
            formUpdateInfor.Show();
        }
        
        private async void InforUsers_Load(object sender, EventArgs e)
        {
           await LoadUserInfo();
        }
        private async Task LoadUserInfo()
        {
            using HttpClient client = new HttpClient();

            var res = await client.GetAsync($"{baseUrl}users/{userId}");
            if (!res.IsSuccessStatusCode)
            {
                MessageBox.Show("Không lấy được thông tin user");
                return;
            }

            string json = await res.Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<UserResponse>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (data == null || data.Status == false)
            {
                MessageBox.Show("User không tồn tại");
                return;
            }
            tb_username.Text = data.Username;
            tb_fullname.Text = data.FullName;
            tb_email.Text = data.Email;
            tb_age.Text = data.Age.ToString();
            tb_address.Text = data.Address;
            tb_NgaySinh.Text = data.Birth.ToString("yyyy-MM-dd");
        }
        private async Task UploadAvatar()
        {
            if (string.IsNullOrEmpty(imagePath))
                return;

            using HttpClient client = new HttpClient();
            using MultipartFormDataContent form = new MultipartFormDataContent();

            var fileStream = File.OpenRead(imagePath);
            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

            form.Add(fileContent, "avatar", Path.GetFileName(imagePath));

            var res = await client.PutAsync(
                $"{baseUrl}users/{userId}/avatar",
                form);

            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Upload ảnh đại diện thành công");
            }
            else
            {
                MessageBox.Show("Upload ảnh thất bại");
            }
        }

    }
}
