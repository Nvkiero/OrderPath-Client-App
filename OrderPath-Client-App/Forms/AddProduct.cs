using OrderPath_Client_App.Data;
using OrderPath_Client_App.Models;
using System;
using System.Drawing; 
using System.Net.Http.Json;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private async void bttn_productAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate giá tiền
                if (!decimal.TryParse(txb_productPrice.Text, out decimal price))
                {
                    MessageBox.Show("Giá tiền phải là số.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Validate ảnh
                // Kiểm tra xem TextBox chứa đường dẫn ảnh có bị trống không
                if (string.IsNullOrWhiteSpace(txb_productImgUrl.Text))
                {
                    MessageBox.Show("Vui lòng chọn ảnh cho sản phẩm!", "Thiếu ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Tạo object dữ liệu
                var newProduct = new AddProductDTO
                {
                    Name = txb_productName.Text,
                    Price = price,
                    Quantity = (int)num_productQuantity.Value,
                    // Lấy đường dẫn file từ TextBox (đã được điền tự động khi Browse ảnh)
                    Image = txb_productImgUrl.Text,
                    Category = txb_productCategory.Text,
                    Description = txb_productDescribtion.Text
                };

                // 4. Gửi lên Server
                var response = await ApiClient.Client.PostAsJsonAsync("seller/products", newProduct);
                MessageBox.Show(response.ToString());
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại: " + response.StatusCode, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e) { }

        private void btn_browseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // Chỉ lọc lấy file ảnh
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            open.Title = "Chọn ảnh sản phẩm";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // 1. Hiển thị ảnh lên PictureBox để xem trước
                pbx_productImg.Image = Image.FromFile(open.FileName);

                // 2. Gán đường dẫn file vào TextBox (để lát nữa gửi lên server)
                txb_productImgUrl.Text = open.FileName;
            }
        }
    }
}