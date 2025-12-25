using Newtonsoft.Json; // Nhớ check đã cài Newtonsoft.Json chưa
using OrderPath_Client_App.Data;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        // --- BỔ SUNG: Hàm nhận ID từ SellerGUI ---
        public void SetOrderId(int id)
        {
            txb_deleteID.Text = id.ToString();
            txb_deleteID.Enabled = false; // Khóa lại
        }

        private async void bttn_orderDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txb_deleteID.Text, out int id))
            {
                MessageBox.Show("ID đơn hàng không hợp lệ.");
                return;
            }

            // Hỏi lại cho chắc ăn
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn hủy đơn hàng #{id} không?",
                                                  "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                // 1. Tạo dữ liệu JSON: Status là "Đã hủy"
                var data = new { Status = "Đã hủy" };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 2. Gọi đúng API Server
                var response = await ApiClient.Client.PutAsync($"seller/orders/{id}/status", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Đã hủy đơn hàng #{id}!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Không thể hủy đơn hàng. Lỗi: " + response.ReasonPhrase, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}