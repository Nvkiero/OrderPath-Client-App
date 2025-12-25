using OrderPath_Client_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OrderPath_Client_App.Forms
{
    public partial class DanhSachGioHang : Form
    {
        public DanhSachGioHang()
        {
            InitializeComponent();
            _service = new CustomerServiced();
        }
        private List<CartItemDTO> cartItems = new();
        private readonly CustomerServiced _service;

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;

            int productId = (int)dgvGioHang.CurrentRow.Cells["ProductId"].Value;

            bool ok = await _service.RemoveFromCartAsync(productId);
            if (ok)
            {
                MessageBox.Show("Xóa thành công");
                LoadCart();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool success = await _service.CheckoutAsync();
            if (success)
            {
                MessageBox.Show("Đặt hàng thành công");
                LoadCart();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }

        private async void LoadCart()
        {
            try
            {
                cartItems = await _service.GetCartAsync();

                dgvGioHang.DataSource = null;
                dgvGioHang.DataSource = cartItems;

                // Ẩn cột không cần thiết
                dgvGioHang.Columns["ProductId"].Visible = false;
                dgvGioHang.Columns["Image"].Visible = false;

                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải giỏ hàng: " + ex.Message);
            }
        }

        private async void DanhSachGioHang_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void UpdateTotal()
        {
            decimal total = cartItems.Sum(c => c.Price * c.Quantity);
            lblTongTien.Text = $"Tổng tiền: {total:N0} đ";
        }
    }
}
