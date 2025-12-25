// File: Models/SellerModels.cs (Dùng cho cả Server và Client)
using System;

namespace ServerWebAPI.Models.Seller
{
    public class AddProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }

    public class ChangeProduct : AddProduct
    {
        public int id { get; set; }
    }

    public class ProductDTO // Dùng để hiển thị danh sách
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}

namespace ServerWebAPI.Models.Seller.QuanLyDonHang
{
    public class GetOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}