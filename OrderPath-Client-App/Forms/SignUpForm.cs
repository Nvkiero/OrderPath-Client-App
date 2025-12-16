using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

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
       
        private async void bt_DangKi_Click(object sender, EventArgs e)
        {
            string username = tb_TenDangNhap.Text.Trim();
            string password = tb_MatKhau.Text;
            string confirmPassword = tb_XacNhan.Text;
            string fullname = tb_HoTen.Text.Trim();
            string email = tb_gmail.Text.Trim();
            string phone = tb_Phone.Text.Trim();
            string address = tb_Address.Text.Trim();
            int age = int.Parse(tb_Age.Text.Trim());
            DateTime birth = dt_Birth.Value;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullname) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            var service = new UserService();
            var newUser = new UserRegister
            {
                Username = username,
                Password = password,
                Fullname = fullname,
                Email = email,
                Phone = phone,
                Address = address,
                Age = age,
                Birth = birth,
            };

            try
            {
                string success = await service.RegisterUser(newUser);
                MessageBox.Show(success);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối server: " + ex.Message);
            }
        }
    }
}
