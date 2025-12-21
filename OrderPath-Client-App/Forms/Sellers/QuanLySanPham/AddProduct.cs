using Newtonsoft.Json;

using OrderPath_Client_App.Models;

using System;

using System.Net.Http;

using System.Text;

using System.Windows.Forms;



namespace OrderPath_Client_App.Forms.Sellers

{

    public partial class AddProduct : Form

    {

        public AddProduct()

        {

            InitializeComponent();

        }



        private async void bttn_productAdd_Click(object sender, EventArgs e)

        {

            try

            {

                // Validate giá tiền

                if (!decimal.TryParse(txb_productPrice.Text, out decimal price))

                {

                    MessageBox.Show("Giá tiền phải là số.");

                    return;

                }



                // Tạo object dữ liệu

                var newProduct = new AddProductDTO

                {

                    Name = txb_productName.Text,

                    Price = price,

                    Quantity = (int)num_productQuantity.Value,

                    Image = txb_productImgUrl.Text,

                    Category = txb_productCategory.Text,

                    Description = txb_productDescribtion.Text

                };



                // Gửi lên Server

                using (HttpClient client = new HttpClient())

                {

                    var jsonContent = new StringContent(JsonConvert.SerializeObject(newProduct), Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://localhost:5275/seller/products", jsonContent);



                    if (response.IsSuccessStatusCode)

                    {

                        MessageBox.Show("Thêm sản phẩm thành công!");

                        this.Close(); // Đóng form

                    }

                    else

                    {

                        MessageBox.Show("Thất bại: " + response.StatusCode);

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi: " + ex.Message);

            }

        }



        // Giữ lại các hàm cũ rỗng để không lỗi Designer

        private void AddProduct_Load(object sender, EventArgs e) { }


    }

}