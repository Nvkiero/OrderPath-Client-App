using System;
using System.Net.Http;
using System.Windows.Forms;
using OrderPath_Client_App.Data;

namespace OrderPath_Client_App.Forms.Sellers
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void txb_productName_TextChanged(object sender, EventArgs e) { }

        private async void bttn_productDelete_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ID đầu vào
            if (string.IsNullOrWhiteSpace(txb_productID.Text) || !int.TryParse(txb_productID.Text, out int id))
            {
                MessageBox.Show("Vui lòng nhập ID sản phẩm hợp lệ (số nguyên).");
                return;
            }

            // 2. Hỏi xác nhận
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
                // Dùng ApiClient thay vì new HttpClient
                // Token đã có sẵn trong header của ApiClient.Client
                // URL chỉ cần phần đuôi
                string url = $"seller/products/{id}/delete";

                HttpResponseMessage response = await ApiClient.Client.PutAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa sản phẩm thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response.StatusCode}. Có thể ID không tồn tại.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối Server: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}