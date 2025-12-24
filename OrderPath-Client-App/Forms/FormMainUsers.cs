using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderPath_Client_App.Forms;
namespace OrderPath_Client_App
{
    public partial class FormMainUsers : Form
    {
        private readonly CustomerServiced _service = new();
        public FormMainUsers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DanhSachGioHang danhSachGioHang = new DanhSachGioHang();
            danhSachGioHang.Show();
        }

        private async void FormMainUsers_Load(object sender, EventArgs e)
        {
            var products = await _service.GetProducts();
            dgvProducts.DataSource = products;

            dgvProducts.Columns["Id"].Visible = false;
            dgvProducts.Columns["Quantity"].HeaderText = "Còn";
            dgvProducts.Columns["Name"].HeaderText = "Sản phẩm";
            dgvProducts.Columns["Price"].HeaderText = "Giá";
            dgvProducts.Columns["Category"].HeaderText = "Loại";

            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "N0";
        }

        private async void bt_search_Click_1(object sender, EventArgs e)
        {
            string keyword = tb_ThanhTimKiem.Text.Trim();
            if (keyword == "") return;

            dgvProducts.DataSource = await _service.SearchProduct(keyword);
        }
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int productId = (int)dgvProducts.Rows[e.RowIndex].Cells["Id"].Value;

            FormProductDetail f = new FormProductDetail(productId);
            f.ShowDialog();
        }


    }
}
