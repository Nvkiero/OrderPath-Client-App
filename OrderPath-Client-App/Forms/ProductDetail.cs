using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        // Hàm này được gọi từ SellerGUI khi double click
        public void LoadData(int id, string name, decimal price, int quantity, string img, string category, string desc)
        {
            // Gán dữ liệu vào các TextBox/Label
            txb_productName.Text = name;
            txb_productPrice.Text = price.ToString("N0") + " VNĐ"; // Format tiền Việt
            num_productQuantity.Value = quantity;
            txb_productCategory.Text = category;
            txb_productDescribtion.Text = desc;
            txb_productImgUrl.Text = img;

            // Xử lý load ảnh
            if (!string.IsNullOrEmpty(img))
            {
                try
                {
                    pbx_productImg.Image = Image.FromFile(img);
                    pbx_productImg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    pbx_productImg.Image = null;
                }
            }
        }
    }
}