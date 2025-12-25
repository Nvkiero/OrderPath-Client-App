using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public class ShipperProfileResponse
    {
        public int ShipperId { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Vehicle { get; set; }
        public int TotalDeliveries { get; set; }
    }

    public class ShipperOrderResponse
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; } = string.Empty
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class UpdateStatusRequest
    {
        public int OrderId { get; set; }
        public string NewStatus { get; set; }
    }
}
