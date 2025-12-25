using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public class OrderItemDTO
    {
        public string ProductName { get; set; } = string.Empty; // tránh null
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal => Price * Quantity;
    }
}
