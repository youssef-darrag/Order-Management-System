namespace OrderManagementSystem.Core.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = default!; // Navigation property to the order
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!; // Navigation property to the product
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice; // Computed property for total price
    }
}
