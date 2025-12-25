using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPath_Client_App.Data.Seller.QuanLyDonHang
{
    public class SellerGetOrder
    {
        public int OrderId { get; set; }
        public int CustomerId {  get; set; }
        public double Total { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
