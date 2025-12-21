using System;
using System.Net.Http;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder()
        {
            InitializeComponent();
        }

        private async void bttn_orderConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txb_confirmID.Text, out int id))
            {
                MessageBox.Show("ID đơn hàng không hợp lệ.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Gửi lệnh PUT (body rỗng vì ID nằm trên URL)
                    var response = await client.PutAsync($"http://localhost:5275/seller/orders/{id}/confirm", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Đã xác nhận đơn hàng #{id}!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy đơn hàng hoặc lỗi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}