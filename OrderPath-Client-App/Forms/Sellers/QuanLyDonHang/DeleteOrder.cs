using System;
using System.Net.Http;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private async void bttn_orderDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txb_deleteID.Text, out int id))
            {
                MessageBox.Show("ID đơn hàng không hợp lệ.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Gửi lệnh PUT hủy đơn
                    var response = await client.PutAsync($"http://localhost:5275/seller/orders/{id}/cancel", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Đã hủy đơn hàng #{id}!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy đơn hàng này.");
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