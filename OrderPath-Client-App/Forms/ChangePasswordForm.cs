using OrderPath_Client_App.Data;
using System;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly string _token;

        private bool showOldPass = false;
        private bool showNewPass = false;

        public ChangePasswordForm(string token)
        {
            InitializeComponent();
            _token = token;
        }

        private void pbOldPass_Click(object sender, EventArgs e)
        {
            showOldPass = !showOldPass;
            txtOldPass.UseSystemPasswordChar = !showOldPass;
        }

        private void pbNewPass_Click(object sender, EventArgs e)
        {
            showNewPass = !showNewPass;
            txtNewPass.UseSystemPasswordChar = !showNewPass;
        }

        private async void btnConfirmnNewPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPass.Text) ||
                string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu cũ và mới");
                return;
            }

            if (txtNewPass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải ít nhất 6 ký tự");
                return;
            }

            var model = new ChangePassword
            {
                OldPassword = txtOldPass.Text,
                NewPassword = txtNewPass.Text
            };

            try
            {
                string result = await _userService.ChangePasswordAsync(model, _token);
                MessageBox.Show(result, "Thông báo");

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
    }
}
