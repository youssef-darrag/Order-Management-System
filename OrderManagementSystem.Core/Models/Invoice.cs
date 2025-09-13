namespace OrderManagementSystem.Core.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = default!; // Navigation property to the order
        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow; // Date when the invoice was generated
        public decimal TotalAmount { get; set; } // Total amount on the invoice
    }
}
