using T_Cas.Business.Models;

namespace T_Cas.Business.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> CreateUserAsync(CreateUserDto user);
        Task<UserDto?> GetUserByIdAsync(int id);
        Task<UserDto?> GetUserByUsernameAsync(string username, string password);
        Task<UserDto?> UpdateUserAsync(UpdateUserDto user);
        Task<bool> DeleteUserAsync(int id);
    }
}
