namespace OrderManagementSystem.Core.DTOs.Auth
{
    public class AddRoleDto
    {
        public string UserId { get; set; } = default!;
        public string Role { get; set; } = default!;
    }
}
