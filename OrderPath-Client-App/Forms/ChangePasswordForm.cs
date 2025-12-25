using Newtonsoft.Json.Linq;
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
    public partial class ChangePasswordForm : Form
    {
        bool flag = false;
        private readonly UserService _userService = new UserService();
        private readonly string _token;

        public ChangePasswordForm(string token)
        {
            InitializeComponent();
            _token = token;
        }

        private void pbOldPass_Click(object sender, EventArgs e)
        {
            flag = !flag;
            txtOldPass.UseSystemPasswordChar = flag;
        }

        private void pbNewPass_Click(object sender, EventArgs e)
        {
            flag = !flag;
            txtNewPass.UseSystemPasswordChar = flag;
        }

        private async void btnConfirmnNewPass_Click(object sender, EventArgs e)
        {
            var model = new ChangePassword
            {
                OldPassword = txtOldPass.Text,
                NewPassword = txtNewPass.Text
            };

            string result = await _userService.ChangePasswordAsync(model, _token);
            MessageBox.Show(result);
        }
    }
}
