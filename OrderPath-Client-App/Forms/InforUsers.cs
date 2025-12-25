using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderPath_Client_App.Data; // Để dùng Session, UserResponse, UpdateUserDTO
using OrderPath_Client_App.Forms;

namespace OrderPath_Client_App
{
    public partial class InforUsers : Form
    {
 

        // Biến lưu đường dẫn ảnh tạm thời
        private string imagePath = "";

        //  Khai báo UserService
        private readonly UserService _userService;
        private UserResponse _currentUser;

        public InforUsers()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async void InforUsers_Load(object sender, EventArgs e)
        {
            // Kiểm tra bảo mật: Nếu chưa đăng nhập (UserId = 0) thì chặn lại
            if (Session.UserId <= 0)
            {
                MessageBox.Show("Bạn chưa đăng nhập. Vui lòng đăng nhập lại!");
                this.Close(); // Đóng form này
                return;
            }

            await LoadUserInfo();
        }

        // --- HÀM 1: LẤY DỮ LIỆU TỪ SERVER ---
        private async Task LoadUserInfo()
        {
            try
            {
                // THAY ĐỔI QUAN TRỌNG: Dùng Session.UserId thay vì biến userId cũ
                _currentUser = await _userService.GetUserById();
                if (_currentUser == null)
                {
                    MessageBox.Show("Không tải được thông tin User.");
                    return;
                }

                // Đổ dữ liệu lên UI
                tb_username.Text = _currentUser.Username;
                tb_fullname.Text = _currentUser.FullName;
                tb_email.Text = _currentUser.Email;
                tb_age.Text = _currentUser.Age.ToString();
                tb_address.Text = _currentUser.Address;
                tb_NgaySinh.Text = _currentUser.Birth.ToString("yyyy-MM-dd");
                tb_Phone.Text = _currentUser.Phone;

                // Nếu UserResponse có Avatar thì load ảnh lên (nếu server trả về link ảnh)
                // if (!string.IsNullOrEmpty(_currentUser.Avatar)) { ... }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // --- HÀM 2: LOGIC CẬP NHẬT (Confirm & Save) ---
        private async void bt_thayDoiThongTin_Click(object sender, EventArgs e)
        {
            // Upload ảnh trước (nếu có chọn ảnh mới)
            await UploadAvatar();

            if (_currentUser == null) return;

            // Mở form con, truyền dữ liệu hiện tại vào
            using (var frm = new FormUpdateInfor(_currentUser))
            {
                // Dùng ShowDialog để đợi kết quả
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu mới từ form con trả về
                    var newData = frm.ResultDTO;

                    // Cập nhật UI tạm thời (Preview) cho người dùng thấy
                    tb_fullname.Text = newData.Fullname;
                    tb_email.Text = newData.Email;
                    tb_age.Text = newData.Age.ToString();
                    tb_address.Text = newData.Address;
                    tb_NgaySinh.Text = newData.Birth.ToString("yyyy-MM-dd");

                    // CONFIRM: Hỏi xác nhận
                    var confirm = MessageBox.Show(
                        "Thông tin hiển thị đã thay đổi. Bạn có muốn lưu vào hệ thống không?",
                        "Xác nhận cập nhật",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        // THAY ĐỔI QUAN TRỌNG: Dùng Session.UserId để update đúng người
                        bool success = await _userService.UpdateProfile(Session.UserId, newData);

                        if (success)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            await LoadUserInfo(); // Tải lại dữ liệu mới nhất
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Đang hoàn tác dữ liệu cũ...");
                            await LoadUserInfo(); // Load lại dữ liệu cũ
                        }
                    }
                    else
                    {
                        // Chọn No -> Load lại dữ liệu cũ
                        await LoadUserInfo();
                    }
                }
            }
        }

        // --- HÀM UPLOAD ẢNH ---
        private async Task UploadAvatar()
        {
            if (string.IsNullOrEmpty(imagePath)) return;

            try
            {
                // Tạo client tạm thời dùng chung BaseAddress
                using var client = new HttpClient { BaseAddress = ApiClient.Client.BaseAddress };

                // (Tùy chọn) Nếu API yêu cầu Token, bạn cần thêm dòng này:
                // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Session.Token);

                using var form = new MultipartFormDataContent();

                using var fileStream = File.OpenRead(imagePath);
                using var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                form.Add(fileContent, "avatar", Path.GetFileName(imagePath));

             
                var res = await client.PutAsync($"users/{Session.UserId}/avatar", form);

                if (res.IsSuccessStatusCode) MessageBox.Show("Upload ảnh thành công");
                else MessageBox.Show("Upload ảnh thất bại");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi upload ảnh: " + ex.Message); }
        }

        private void pB_AnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png;*.jpeg" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pB_AnhDaiDien.Image = Image.FromFile(imagePath);
                pB_AnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void bt_DoiMatKhau_Click(object sender, EventArgs e)
        {
            // Ví dụ mở form đổi mật khẩu
            // new ChangePasswordForm().ShowDialog();
        }
    }
}