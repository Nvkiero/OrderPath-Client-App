using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data
{
    public class OrderDetailDTO
    {
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Total { get; set; }
        public string? Status { get; set; }
        public List<OrderItemDTO> Items { get; set; } = new();
    }
}
