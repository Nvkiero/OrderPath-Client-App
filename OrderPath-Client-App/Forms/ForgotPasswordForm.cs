using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly UserService _userService = new UserService();

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

            bool success = await _userService.SendOtpAsync(txtEmail.Text);

            if (success)
                MessageBox.Show("OTP đã được gửi (check console server)");
            else
                MessageBox.Show("Gửi OTP thất bại");
        }

        private async void btnConfirmnNewPass_Click(object sender, EventArgs e)
        {
            var model = new ForgotPassword
            {
                Email = txtEmail.Text,
                OTP = txtOTP.Text,
                NewPassword = txtNewPassword.Text
            };

            string result = await _userService.ForgotPasswordAsync(model);
            MessageBox.Show(result);
        }

        private void pbNewPass_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = !flag;
            txtNewPassword.UseSystemPasswordChar = flag;
        }
    }
}
