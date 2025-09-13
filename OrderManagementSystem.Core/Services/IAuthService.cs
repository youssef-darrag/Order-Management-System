using OrderManagementSystem.Api.DTOs;

namespace OrderManagementSystem.Core.Services
{
    public interface IAuthService
    {
        Task<AuthDto> RegisterAsync(RegisterDto dto);
    }
}
