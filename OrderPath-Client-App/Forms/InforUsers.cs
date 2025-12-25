using OrderPath_Client_App.Data;
using OrderPath_Client_App.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPath_Client_App
{
    public partial class InforUsers : Form
    {
        // Biến lưu đường dẫn ảnh tạm thời khi người dùng chọn từ máy tính
        private string imagePath = "";

        // Khai báo UserService để gọi API
        private readonly UserService _userService;

        // Biến lưu thông tin User hiện tại để truyền sang form con
        private UserResponse _currentUser;

        public InforUsers()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        // --- SỰ KIỆN 1: LOAD FORM ---
        private async void InforUsers_Load(object sender, EventArgs e)
        {
            // Kiểm tra bảo mật: Nếu chưa có Token (chưa đăng nhập) thì chặn lại
            if (string.IsNullOrEmpty(Session.Token))
            {
                MessageBox.Show("Phiên đăng nhập đã hết hạn hoặc bạn chưa đăng nhập. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Đóng form này
                return;
            }

            // Tải thông tin người dùng lên giao diện
            await LoadUserInfo();
        }

        // --- HÀM HỖ TRỢ: GỌI API LẤY THÔNG TIN ---
        private async Task LoadUserInfo()
        {
            try
            {
                // Gọi API GetMyProfile thông qua UserService (có truyền Token)
                _currentUser = await _userService.GetMyProfile(Session.Token);

                if (_currentUser == null)
                {
                    MessageBox.Show("Không tải được thông tin cá nhân. Vui lòng kiểm tra kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đổ dữ liệu lên các TextBox/Label
                tb_username.Text = _currentUser.Username;
                tb_fullname.Text = _currentUser.FullName;
                tb_email.Text = _currentUser.Email;
                tb_age.Text = _currentUser.Age.ToString();
                tb_address.Text = _currentUser.Address;
                tb_Phone.Text = _currentUser.Phone;
                tb_NgaySinh.Text = _currentUser.Birth.ToString("yyyy-MM-dd");

                // Xử lý hiển thị Avatar (Nếu server trả về link ảnh)
                if (!string.IsNullOrEmpty(_currentUser.Avatar))
                {
                    try
                    {
                        // Nếu Avatar là đường dẫn web (http...) thì load
                        // Nếu Avatar là đường dẫn file cục bộ thì load file
                        // Ở đây demo load hình mặc định hoặc load từ URL nếu PictureBox hỗ trợ
                        pB_AnhDaiDien.Load(_currentUser.Avatar);
                    }
                    catch
                    {
                        // Nếu lỗi load ảnh thì thôi, giữ ảnh mặc định
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SỰ KIỆN 2: CLICK NÚT CẬP NHẬT THÔNG TIN ---
        private async void bt_thayDoiThongTin_Click(object sender, EventArgs e)
        {
            // 1. Nếu người dùng có chọn ảnh mới, thực hiện Upload trước
            if (!string.IsNullOrEmpty(imagePath))
            {
                await UploadAvatar();
            }

            if (_currentUser == null) return;

            // 2. Mở FormUpdateInfor và truyền dữ liệu hiện tại vào (để hiển thị sẵn)
            using (var frmUpdate = new FormUpdateInfor(_currentUser))
            {
                // Dùng ShowDialog để đợi người dùng thao tác xong
                var result = frmUpdate.ShowDialog();

                // 3. Nếu người dùng bấm "Cập nhật" (OK) ở form con
                if (result == DialogResult.OK)
                {
                    // Lấy dữ liệu mới từ form con trả về
                    var newData = frmUpdate.ResultDTO;

                    // Update UI Form cha ngay lập tức (Preview cho người dùng thấy)
                    tb_fullname.Text = newData.Fullname;
                    tb_email.Text = newData.Email;
                    tb_age.Text = newData.Age.ToString();
                    tb_address.Text = newData.Address;
                    tb_NgaySinh.Text = newData.Birth.ToString("yyyy-MM-dd");

                    // 4. CONFIRM: Hỏi xác nhận lần cuối trước khi lưu Server
                    var confirm = MessageBox.Show(
                        "Thông tin hiển thị đã được thay đổi. Bạn có chắc chắn muốn lưu vào hệ thống không?",
                        "Xác nhận cập nhật",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        // Gọi UserService để PUT dữ liệu lên Server
                        bool success = await _userService.UpdateProfile(Session.Token, newData);

                        if (success)
                        {
                            MessageBox.Show("Cập nhật thành công vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadUserInfo(); // Tải lại dữ liệu sạch từ server
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Hệ thống sẽ hoàn tác lại dữ liệu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            await LoadUserInfo(); // Revert lại dữ liệu cũ
                        }
                    }
                    else
                    {
                        // Nếu chọn No, load lại dữ liệu cũ từ server để hoàn tác UI
                        await LoadUserInfo();
                    }
                }
            }
        }

        // --- HÀM HỖ TRỢ: UPLOAD AVATAR ---
        private async Task UploadAvatar()
        {
            if (string.IsNullOrEmpty(imagePath)) return;

            try
            {
                // Tạo HttpClient tạm thời dùng chung BaseAddress của ApiClient
                using var client = new HttpClient { BaseAddress = ApiClient.Client.BaseAddress };

                // QUAN TRỌNG: Thêm Token vào Header để Server cho phép Upload
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Session.Token);

                using var form = new MultipartFormDataContent();
                using var fileStream = File.OpenRead(imagePath);
                using var fileContent = new StreamContent(fileStream);

                fileContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                form.Add(fileContent, "avatar", Path.GetFileName(imagePath));

                // Gọi API: PUT users/me/avatar
                var res = await client.PutAsync("users/me/avatar", form);

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Upload ảnh đại diện thành công!", "Thông báo");
                    imagePath = ""; // Reset đường dẫn sau khi up xong
                }
                else
                {
                    MessageBox.Show("Upload ảnh thất bại. Vui lòng thử lại.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi upload ảnh: " + ex.Message, "Lỗi");
            }
        }

        // --- SỰ KIỆN 3: CLICK VÀO ẢNH ĐẠI DIỆN ĐỂ CHỌN ẢNH ---
        private void pB_AnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            ofd.Title = "Chọn ảnh đại diện";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn ảnh vào biến tạm
                imagePath = ofd.FileName;

                // Hiển thị ảnh vừa chọn lên PictureBox (Preview)
                pB_AnhDaiDien.Image = Image.FromFile(imagePath);
                pB_AnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // --- SỰ KIỆN 4: CLICK NÚT ĐỔI MẬT KHẨU ---
        private void bt_DoiMatKhau_Click(object sender, EventArgs e)
        {
            // Kiểm tra Token trước khi mở form
            if (string.IsNullOrEmpty(Session.Token))
            {
                MessageBox.Show("Bạn cần đăng nhập lại để thực hiện chức năng này.");
                return;
            }

            // Mở form đổi mật khẩu (Giả sử bạn đã có ChangePasswordForm)
            // Nếu chưa có form này, bạn có thể comment lại dòng dưới
            ChangePasswordForm frmChangePass = new ChangePasswordForm(Session.Token);
            frmChangePass.ShowDialog();
        }
    }
}