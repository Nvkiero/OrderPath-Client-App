using OrderPath_Client_App.Data;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class OrderPath : Form
    {
        public OrderPath()
        {
            InitializeComponent();

            // Gán event đúng chỗ
            dgvOrders.SelectionChanged += async (s, e) =>
            {
                if (dgvOrders.CurrentRow != null)
                {
                    int orderId = (int)dgvOrders.CurrentRow.Cells["OrderId"].Value;
                    await LoadOrderItems(orderId);
                }
            };

            // Load danh sách đơn khi mở form
            LoadOrders();
        }
        private readonly CustomerServiced _service = new();
        private async Task LoadOrders()
        {
            try
            {
                var orders = await _service.GetMyOrders(); // gọi API
                dgvOrders.DataSource = orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load orders: " + ex.Message);
            }
        }

        private async Task LoadOrderItems(int orderId)
        {
            try
            {
                var order = await _service.GetOrderDetail(orderId);
                dgvOrderItems.DataSource = order.Items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load order items: " + ex.Message);
            }
        }

        //private async void BtnShowMap_Click(object sender, EventArgs e)
        //{
        //    if (dgvOrders.CurrentRow != null)
        //    {
        //        int orderId = (int)dgvOrders.CurrentRow.Cells["OrderId"].Value;
        //        // Lấy thông tin shipper từ API
        //        var shipper = await ApiClient.GetShipperLocation(orderId); // giả sử API trả về lat/lng và tên

        //        // Mở form map
        //        var mapForm = new ShipperMapForm(shipper.Latitude, shipper.Longitude, shipper.Name);
        //        mapForm.ShowDialog();
        //    }
        //}

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
