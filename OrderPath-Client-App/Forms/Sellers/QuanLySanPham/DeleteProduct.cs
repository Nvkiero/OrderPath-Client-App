using System;
using System.Net.Http; // Cần cái này để gọi Server
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        // Sự kiện này do Designer tự tạo (do copy paste hoặc nhầm tên), cứ để trống để không lỗi
        private void txb_productName_TextChanged(object sender, EventArgs e)
        {
        }

        // Xử lý khi bấm nút XÓA
        private async void bttn_productDelete_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ID đầu vào
            if (string.IsNullOrWhiteSpace(txb_productID.Text) || !int.TryParse(txb_productID.Text, out int id))
            {
                MessageBox.Show("Vui lòng nhập ID sản phẩm hợp lệ (số nguyên).");
                return;
            }

            // 2. Hỏi xác nhận cho chắc ăn
            var confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm ID: {id} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // 3. Gọi Server để xóa
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // URL API: localhost:5275/seller/products/{id}/delete
                    string url = $"http://localhost:5275/seller/products/{id}/delete";

                    // Gọi method PUT (theo quy định bên Server của bạn)
                    HttpResponseMessage response = await client.PutAsync(url, null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã xóa sản phẩm thành công!");
                        this.Close(); // Đóng form sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi: {response.StatusCode}. Có thể ID không tồn tại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối Server: " + ex.Message);
            }
        }
    }
}