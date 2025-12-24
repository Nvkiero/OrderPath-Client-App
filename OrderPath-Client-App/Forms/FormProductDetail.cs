using OrderPath_Client_App.Data;
using ServerWebAPI.Models.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OrderPath_Client_App.Forms
{
    public partial class FormProductDetail : Form
    {
        private int _productId;
        public FormProductDetail(int productId)
        {
            InitializeComponent();
            _productId = productId;
            this.Load += FormProductDetail_Load;
        }

        private async void FormProductDetail_Load(object sender, EventArgs e)
        {
            var product = await ApiClient.Client
                .GetFromJsonAsync<ProductDTO>($"customer/products/{_productId}");

            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                return;
            }

            lbName.Text = product.Name;
            lbPrice.Text = product.Price.ToString("N0") + " đ";
            lbDesc.Text = product.Description;
        }

        private async void BtnAddToCart_Click(object sender, EventArgs e)
        {
            int qty = (int)nudQuantity.Value;

            var req = new AddCartRequest
            {
                ProductId = _productId,
                Quantity = qty,
            };

            var res = await ApiClient.Client
                .PostAsJsonAsync("customer/cart/add", req);

            if (!res.IsSuccessStatusCode)
            {
                var err = await res.Content.ReadAsStringAsync();
                MessageBox.Show("Thêm thất bại: " + err);
                return;
            }

            MessageBox.Show("Đã thêm vào giỏ hàng");
        }
    }

}
