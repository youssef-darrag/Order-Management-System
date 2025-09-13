using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!; // Navigation property to the customer
        public DateTime OrderDate { get; set; } = DateTime.UtcNow; // Date and time when the order was placed
        public decimal TotalAmount { get; set; }

        [StringLength(100)]
        public string PaymentMethod { get; set; } = default!; // Payment method used

        [StringLength(50)]
        public string Status { get; set; } = "Pending"; // Current status of the order
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // Items in the order
    }
}
