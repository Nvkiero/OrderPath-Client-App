using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace OrderPath_Client_App
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lb_DangKi_Click(object sender, EventArgs e)
        {

        }

        private async Task RegisterUserAsync()
        {
            // Lấy dữ liệu từ các TextBox
            string username = tb_TenDangNhap.Text.Trim();    // Lấy tên đăng nhập, bỏ khoảng trắng đầu/cuối
            string password = tb_MatKhau.Text;              // Lấy mật khẩu
            string confirmPassword = tb_XacNhan.Text;       // Lấy mật khẩu xác nhận
            string fullname = tb_HoTen.Text.Trim();         // Lấy họ tên
            string email = tb_gmail.Text.Trim();            // Lấy email

            // Kiểm tra cơ bản
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullname) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return; // Dừng hàm nếu có trường trống
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return; // Dừng hàm nếu mật khẩu không khớp
            }

            try
            {
                // Tạo HttpClient để gửi request
                using (HttpClient client = new HttpClient())
                {
                    // Đặt địa chỉ server (localhost)
                    client.BaseAddress = new Uri("http://localhost:5000"); 

                    // Chấp nhận dữ liệu JSON
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    // Tạo đối tượng dữ liệu đăng ký
                    var payload = new
                    {
                        username = username,
                        password = password,
                        fullname = fullname,
                        email = email
                    };

                    // Chuyển đối tượng sang JSON
                    string json = JsonSerializer.Serialize(payload);

                    // Gói JSON vào HttpContent
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Gửi POST request đến API /api/auth/register
                    HttpResponseMessage response = await client.PostAsync("/api/auth/register", content);

                    //Kiểm tra phản hồi
                    if (response.IsSuccessStatusCode)
                    {
                        // Nếu thành công, đọc kết quả (JSON)
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Đăng ký thành công!");
                    }
                    else
                    {
                        // Nếu lỗi, đọc thông báo lỗi server
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Đăng ký thất bại: " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                //Bắt lỗi khi không kết nối được server
                MessageBox.Show("Lỗi kết nối server: " + ex.Message);
            }
        }


        private async void bt_DangKi_Click(object sender, EventArgs e)
        {
            await RegisterUserAsync();
        }
    }
}
