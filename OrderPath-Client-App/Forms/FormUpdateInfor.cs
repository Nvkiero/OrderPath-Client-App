using OrderPath_Client_App.Data;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class FormUpdateInfor : Form
    {
        // 1. Biến để chứa dữ liệu trả về cho Form Cha 
        public UpdateUserDTO ResultDTO { get; private set; }

        // 2. Constructor nhận dữ liệu từ Form Cha để hiển thị lên các ô
        public FormUpdateInfor(UserResponse currentData)
        {
            InitializeComponent();

            // Đổ dữ liệu cũ vào form
            if (currentData != null)
            {
                tb_fullname.Text = currentData.FullName;
                tb_username.Text = currentData.Username;
                tb_email.Text = currentData.Email;
                tb_age.Text = currentData.Age.ToString();
                tb_address.Text = currentData.Address;
                tb_NgaySinh.Text = currentData.Birth.ToString("yyyy-MM-dd");
                tb_Phone.Text = currentData.Phone; // Nếu UserResponse có field Phone
            }
        }

        // 3. Xóa hoàn toàn việc gọi API trong Load
        private void FormUpdateInfor_Load(object sender, EventArgs e)
        {
            // Không làm gì cả, dữ liệu đã được nạp ở Constructor
        }

        // 4. Nút Cập nhật chỉ đóng gói dữ liệu và trả về
        private async void bt_CapNhat_Click(object sender, EventArgs e)
        {
            // --- Validate dữ liệu ---
            if (!DateTime.TryParseExact(tb_NgaySinh.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birth))
            {
                MessageBox.Show("Ngày sinh phải đúng định dạng yyyy-MM-dd");
                return;
            }

            if (!int.TryParse(tb_age.Text, out int age))
            {
                MessageBox.Show("Age (Tuổi) phải là số");
                return;
            }

            // --- Đóng gói dữ liệu vào DTO ---
            ResultDTO = new UpdateUserDTO
            {
                Fullname = tb_fullname.Text,
                Email = tb_email.Text,
                Age = age,
                Address = tb_address.Text,
                Birth = birth
            };

            // --- QUAN TRỌNG: Không gọi _userService.UpdateProfile ở đây! ---
            // Chỉ báo OK để Form Cha biết và tự gọi API sau khi Confirm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Các hàm sự kiện thừa (giữ nguyên để không lỗi giao diện)
        private void btnChangePass_Click(object sender, EventArgs e) { }
        private void lb_Age_Click(object sender, EventArgs e) { }
        private void lb_tieuDe_Click(object sender, EventArgs e) { }
    }
}