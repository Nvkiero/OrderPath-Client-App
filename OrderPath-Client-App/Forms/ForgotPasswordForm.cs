using OrderPath_Client_App.Data;
using System;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly UserService _userService = new UserService();
        private bool showNewPass = false;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private async void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }

            try
            {
                bool success = await _userService.SendOtpAsync(txtEmail.Text);

                MessageBox.Show(
                    success ? "OTP đã được gửi, vui lòng kiểm tra email"
                            : "Gửi OTP thất bại"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi OTP: " + ex.Message);
            }
        }

        private async void btnConfirmnNewPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtOTP.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email, OTP và mật khẩu mới");
                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải ít nhất 6 ký tự");
                return;
            }

            var model = new ForgotPassword
            {
                Email = txtEmail.Text.Trim(),
                OTP = txtOTP.Text.Trim(),
                NewPassword = txtNewPassword.Text
            };

            try
            {
                string result = await _userService.ForgotPasswordAsync(model);
                MessageBox.Show(result);

                if (result.Contains("thành công"))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đổi mật khẩu thất bại: " + ex.Message);
            }
        }

        private void pbNewPass_Click(object sender, EventArgs e)
        {
            showNewPass = !showNewPass;
            txtNewPassword.UseSystemPasswordChar = !showNewPass;
        }
    }
}
