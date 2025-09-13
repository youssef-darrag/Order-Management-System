using OrderManagementSystem.Core.DTOs.Auth;

namespace OrderManagementSystem.Core.Services
{
    public interface IAuthService
    {
        Task<AuthDto> RegisterAsync(RegisterDto dto);
        Task<AuthDto> GetTokenAsync(TokenRequestDto dto);
        Task<string> AddRoleAsync(AddRoleDto dto);
    }
}
