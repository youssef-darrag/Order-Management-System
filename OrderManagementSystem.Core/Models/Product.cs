using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = default!;

        [StringLength(200)]
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; } // Available stock quantity
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!; // Navigation property to the category
    }
}
