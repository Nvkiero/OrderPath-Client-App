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


        public void SetProductId(int id)
        {
            // Giả sử tên textbox nhập ID của bạn là txb_deleteID
            // Nếu tên khác thì bạn đổi lại cho đúng (ví dụ: txtId, txbId...)
            if (Controls.ContainsKey("txb_deleteID"))
            {
                Controls["txb_deleteID"].Text = id.ToString();
                Controls["txb_deleteID"].Enabled = false; // Khóa lại không cho sửa
            }
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
                string url = $"seller/products/{id}";

                HttpResponseMessage response = await ApiClient.Client.PutAsync(url, null);
                MessageBox.Show(response.ToString());
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