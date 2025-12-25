using Newtonsoft.Json; 
using OrderPath_Client_App.Data;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder()
        {
            InitializeComponent();
        }

        //  Hàm nhận ID từ SellerGUI 
        public void SetOrderId(int id)
        {
            // Tự động điền ID vào ô textbox và khóa lại không cho sửa
            txb_confirmID.Text = id.ToString();
            txb_confirmID.Enabled = false; // Khóa lại cho an toàn
        }

        private async void bttn_orderConfirm_Click(object sender, EventArgs e)
        {
            // Lấy ID từ textbox (đã được điền tự động)
            if (!int.TryParse(txb_confirmID.Text, out int id))
            {
                MessageBox.Show("ID đơn hàng không hợp lệ.", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Tạo dữ liệu JSON để gửi đi (Khớp với UpdateStatusReq bên Server)
                var data = new { Status = "Đã xác nhận" };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 2. Gọi đúng API Server: PUT seller/orders/{id}/status
                var response = await ApiClient.Client.PutAsync($"seller/orders/{id}/status", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Đã xác nhận đơn hàng #{id} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi xong
                }
                else
                {
                    MessageBox.Show("Lỗi từ Server: " + response.ReasonPhrase, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}