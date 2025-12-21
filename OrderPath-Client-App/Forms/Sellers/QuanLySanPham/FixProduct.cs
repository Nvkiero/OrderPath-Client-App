using Newtonsoft.Json;
using OrderPath_Client_App.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms.Sellers
{
    public partial class FixProduct : Form
    {
        public FixProduct()
        {
            InitializeComponent();
        }

        private async void bttn_productFix_Click(object sender, EventArgs e)
        {
            // Validate ID
            if (!int.TryParse(txb_productID.Text, out int id))
            {
                MessageBox.Show("Vui lòng nhập ID sản phẩm hợp lệ.");
                return;
            }

            if (!decimal.TryParse(txb_productPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá tiền phải là số.");
                return;
            }

            try
            {
                var updateProduct = new ChangeProductDTO
                {
                    id = id, // Quan trọng: Server check ID này
                    Name = txb_productName.Text,
                    Price = price,
                    Quantity = (int)num_productQuantity.Value,
                    Image = txb_productImgUrl.Text,
                    Category = txb_productCategory.Text,
                    Description = txb_productDescribtion.Text
                };

                using (HttpClient client = new HttpClient())
                {
                    var jsonContent = new StringContent(JsonConvert.SerializeObject(updateProduct), Encoding.UTF8, "application/json");

                    // Gọi method PUT
                    var response = await client.PutAsync($"http://localhost:5275/seller/products/{id}", jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sửa sản phẩm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm hoặc lỗi server.");
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