using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderPath_Client_App.Data;

namespace OrderPath_Client_App.Forms
{
    public partial class ShipperForm : Form
    {
        private readonly int _currentShipperId;

        public ShipperForm(int shipperId)
        {
            InitializeComponent();

            _currentShipperId = shipperId;

            this.Load += ShipperForm_Load;
        }

        private async void ShipperForm_Load(object sender, EventArgs e)
        {
            await LoadProfile();
            await LoadOrders();
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await LoadOrders();
        }

        private async void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a new status.");
                return;
            }

            var selectedOrder = (ShipperOrderResponse)dgvOrders.SelectedRows[0].DataBoundItem;
            string newStatus = cmbStatus.SelectedItem.ToString();

            var request = new UpdateStatusRequest
            {
                OrderId = selectedOrder.OrderId,
                NewStatus = newStatus
            };

            try
            {
                var response = await ApiClient.Client.PostAsJsonAsync("shipper/update-status", request);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Status updated successfully!");
                    await LoadOrders();
                }
                else
                {
                    MessageBox.Show("Failed to update status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task LoadProfile()
        {
            try
            {
                var response = await ApiClient.Client.GetFromJsonAsync<ShipperProfileResponse>($"shipper/{_currentShipperId}");
                if (response != null)
                {
                    lblCompanyNameVal.Text = response.Username;
                    lblPhoneVal.Text = response.Phone;
                    lblVehicleVal.Text = response.Vehicle;
                    lblTotalDeliveriesVal.Text = response.TotalDeliveries.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private async Task LoadOrders()
        {
            try
            {
                var orders = await ApiClient.Client.GetFromJsonAsync<List<ShipperOrderResponse>>("shipper/orders");
                dgvOrders.DataSource = orders;

                // Optional: Hide specific columns if needed
                // if(dgvOrders.Columns["OrderId"] != null) dgvOrders.Columns["OrderId"].HeaderText = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}