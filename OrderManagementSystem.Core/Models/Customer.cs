using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = default!;

        [DataType(DataType.EmailAddress), StringLength(80)]
        public string Email { get; set; } = default!;

        [DataType(DataType.PhoneNumber), StringLength(20)]
        public string Phone { get; set; } = default!;

        [StringLength(100)]
        public string Address { get; set; } = default!;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
