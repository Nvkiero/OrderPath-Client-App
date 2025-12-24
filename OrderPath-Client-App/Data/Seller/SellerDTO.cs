using System;

namespace OrderPath_Client_App.Models
{
    // DTO gửi đi khi thêm sản phẩm
    public class AddProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }

    // DTO gửi đi khi sửa sản phẩm
    public class ChangeProductDTO : AddProductDTO
    {
        public int id { get; set; }
    }

    // DTO nhận về để hiển thị danh sách sản phẩm
    public class ProductResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }

    // DTO nhận về để hiển thị danh sách đơn hàng
    public class OrderResponseDTO
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}