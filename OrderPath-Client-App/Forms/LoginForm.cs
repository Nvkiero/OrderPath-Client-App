using OrderPath_Client_App.Data;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OrderPath_Client_App
{
    public partial class LoginForm : Form
    {
        // biến flag điều khiển passwordchar
        bool flag = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pb_exit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_TenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_TenDangNhap_Enter(object sender, EventArgs e)
        {
            if (lb_TieuDe.Visible && tb_TenDangNhap.Text == "")
            {
                lb_TieuDe.Visible = false;
            }
        }

        private void tb_TenDangNhap_Leave(object sender, EventArgs e)
        {
            if (tb_TenDangNhap.Text == "")
            {
                lb_TieuDe.Visible = true; // Hiện lại placeholder nếu người dùng để trống
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_MatKhau_Click(object sender, EventArgs e)
        {

        }

        private void tb_MatKhau_Enter(object sender, EventArgs e)
        {
            if (lb_MatKhau.Visible && tb_MatKhau.Text == "")
            {
                lb_MatKhau.Visible = false; // Tắt placeholder nếu người dùng di chuột vào
            }
        }

        private void tb_MatKhau_Leave(object sender, EventArgs e)
        {
            if (tb_MatKhau.Text == "")
            {
                lb_MatKhau.Visible = true; // Hiện lại placeholder nếu người dùng để trống
            }
        }

        private void tb_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Hoac_Click(object sender, EventArgs e)
        {

        }

        private void pb_HinhNen_Click(object sender, EventArgs e)
        {

        }

        private void pb_PassWordChar_Click(object sender, EventArgs e)
        {
            flag = !flag;
            tb_MatKhau.UseSystemPasswordChar = flag;
        }

        private void bt_DangKy_Click(object sender, EventArgs e)
        {
            SignUpForm Dangki = new SignUpForm();
            Dangki.Show();
        }
        private async void bt_DangNhap_Click(object sender, EventArgs e)
        {
            string username = tb_TenDangNhap.Text;
            string password = tb_MatKhau.Text;

            var user = new UserLogin
            {
                Username = username,
                Password = password 
            };

            var service = new UserService();
            var result = await service.LoginUser(user);
            if (result == null)
            {
                MessageBox.Show("Lỗi hệ thống");
                return;
            }

            if (result.StartsWith("ey")) // JWT token
            {
                MessageBox.Show("Đăng nhập thành công");

                //// 🔐 LƯU TOKEN
                //Session.AccessToken = result;

                //// mở form chính
                //new MainForm().Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show(result); // message từ server
            }
        }

    }
}
