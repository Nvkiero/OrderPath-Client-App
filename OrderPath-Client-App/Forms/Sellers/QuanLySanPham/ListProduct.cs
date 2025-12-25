using Newtonsoft.Json;
using OrderPath_Client_App.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers
{
    public partial class ListProduct : Form
    {
        public ListProduct()
        {
            InitializeComponent();
            // Gán sự kiện click cho nút Load
        }

        private async void bttn_getProductList_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Gọi API lấy danh sách
                    var response = await client.GetAsync("http://localhost:5275/seller/products");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var products = JsonConvert.DeserializeObject<List<ProductResponseDTO>>(jsonString);

                        // Hiển thị lên GridView
                        dgv_productList.Rows.Clear();
                        foreach (var p in products)
                        {
                            dgv_productList.Rows.Add(
                                p.Id,
                                p.Name,
                                p.Price,
                                p.Quantity,
                                p.Image,
                                p.Status ? "Active" : "Hidden"
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tải dữ liệu: " + response.ReasonPhrase);
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