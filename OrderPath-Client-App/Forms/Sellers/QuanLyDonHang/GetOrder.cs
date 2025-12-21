using Newtonsoft.Json;
using OrderPath_Client_App.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    public partial class GetOrder : Form
    {
        public GetOrder()
        {
            InitializeComponent();
            // Đã xóa dòng gán sự kiện thủ công ở đây để tránh lỗi trùng lặp
            // Designer sẽ tự động gọi hàm bttn_getProductList_Click bên dưới
        }

        // Đã sửa tên hàm này từ 'bttn_getOrderList_Click' thành 'bttn_getProductList_Click'
        // để khớp với file Designer.cs của bạn
        private async void bttn_getProductList_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // URL: Lấy danh sách đơn hàng
                    var response = await client.GetAsync("http://localhost:5275/seller/orders");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var orders = JsonConvert.DeserializeObject<List<OrderResponseDTO>>(jsonString);

                        dgv_productList.Rows.Clear();

                        // Kiểm tra null để tránh lỗi nếu danh sách trống
                        if (orders != null)
                        {
                            foreach (var o in orders)
                            {
                                dgv_productList.Rows.Add(
                                    o.OrderId,
                                    o.CustomerId,
                                    o.Total,
                                    o.Status,
                                    o.Date
                                );
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tải đơn hàng: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}