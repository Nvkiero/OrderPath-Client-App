using OrderPath_Client_App.Data;
using OrderPath_Client_App.Models;
using System;
using System.Drawing; 
using System.Net.Http.Json;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers
{
    public partial class FixProduct : Form
    {
        // Biến lưu ID sản phẩm đang sửa
        private int _currentProductId;

        public FixProduct()
        {
            InitializeComponent();
        }

        // 1. Hàm nhận dữ liệu từ SellerGUI và hiển thị lên Form
        public void SetProductData(int id, string name, decimal price, int quantity, string img, string category, string desc)
        {
            _currentProductId = id;

            // Đổ dữ liệu text
            txb_productID.Text = id.ToString();
            txb_productName.Text = name;
            txb_productPrice.Text = price.ToString();
            num_productQuantity.Value = quantity;
            txb_productCategory.Text = category;
            txb_productDescribtion.Text = desc;

            // Lưu đường dẫn ảnh vào TextBox (ẩn hoặc hiện tùy bạn, nhưng cần để code chạy)
            txb_productImgUrl.Text = img;

            // Xử lý hiển thị ảnh cũ lên PictureBox
            if (!string.IsNullOrEmpty(img))
            {
                try
                {
                    // Thử load ảnh từ đường dẫn trong máy tính
                    pbx_productImg.Image = Image.FromFile(img);
                }
                catch
                {
                    // Nếu đường dẫn sai hoặc file đã bị xóa, thì để trống ảnh
                    pbx_productImg.Image = null;
                }
            }
            else
            {
                pbx_productImg.Image = null;
            }
        }

        // 2. Sự kiện bấm nút "Chọn ảnh(...)" 
        private void btn_browseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            open.Title = "Chọn ảnh sản phẩm mới";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh vừa chọn lên PictureBox để xem trước
                pbx_productImg.Image = Image.FromFile(open.FileName);

                // Quan trọng: Gán đường dẫn mới vào TextBox để tí nữa gửi lên Server
                txb_productImgUrl.Text = open.FileName;
            }
        }

        // 3. Sự kiện bấm nút "Sửa" (Lưu thay đổi)
        private async void bttn_productFix_Click(object sender, EventArgs e)
        {
            // Validate giá tiền
            if (!decimal.TryParse(txb_productPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá tiền phải là số.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo object chứa dữ liệu cập nhật
                var updateProduct = new ChangeProductDTO
                {
                    id = _currentProductId,
                    Name = txb_productName.Text,
                    Price = price,
                    Quantity = (int)num_productQuantity.Value,

                    // Lấy đường dẫn ảnh từ TextBox (có thể là ảnh cũ hoặc ảnh mới vừa browse)
                    Image = txb_productImgUrl.Text,

                    Category = txb_productCategory.Text,
                    Description = txb_productDescribtion.Text
                };

                // Gửi lệnh PUT lên Server
                // Dùng ApiClient + PutAsJsonAsync
                var response = await ApiClient.Client.PutAsJsonAsync($"seller/products/{_currentProductId}", updateProduct);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi sửa xong
                }
                else
                {
                    MessageBox.Show("Thất bại: " + response.ReasonPhrase, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FixProduct_Load(object sender, EventArgs e) { }
    }
}