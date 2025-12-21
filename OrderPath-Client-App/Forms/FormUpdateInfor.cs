using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class FormUpdateInfor : Form
    {
        private readonly UserService _userService;
        private int userId = 1; // TODO: lấy từ login
        private string imagePath = "";
        public FormUpdateInfor()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async void FormUpdateInfor_Load(object sender, EventArgs e)
        {
            await LoadUserInfo();
        }
        private async Task LoadUserInfo()
        {
            var user = await _userService.GetUserById(userId);

            if (user == null)
            {
                MessageBox.Show("Không lấy được thông tin user");
                return;
            }

            tb_fullname.Text = user.FullName;
            tb_username.Text = user.Username;
            tb_email.Text = user.Email;
            tb_age.Text = user.Age.ToString();
            tb_address.Text = user.Address;
            tb_NgaySinh.Text = user.Birth.ToString("yyyy-MM-dd");
            tb_Phone.Text = ""; // server chưa trả phone
        }

        private async void bt_CapNhat_Click(object sender, EventArgs e)
        {
            // Validate ngày sinh
            if (!DateTime.TryParseExact(
                    tb_NgaySinh.Text,
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime birth))
            {
                MessageBox.Show("Ngày sinh phải đúng định dạng yyyy-MM-dd");
                return;
            }

            if (!int.TryParse(tb_age.Text, out int age))
            {
                MessageBox.Show("Age phải là số");
                return;
            }

            UpdateUserDTO dto = new UpdateUserDTO
            {
                Fullname = tb_fullname.Text,
                Birth = birth,
                Age = age,
                Email = tb_email.Text,
                Address = tb_address.Text
            };

            bool success = await _userService.UpdateProfile(userId, dto);

            if (success)
                MessageBox.Show("Cập nhật thông tin thành công");
            else
                MessageBox.Show("Cập nhật thất bại");
        }
        

        private void lb_Age_Click(object sender, EventArgs e)
        {

        }

        private void lb_tieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
