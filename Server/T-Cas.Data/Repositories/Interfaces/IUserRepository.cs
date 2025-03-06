using T_Cas.Data.Entities;

namespace T_Cas.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> CreateUserAsync(User user);
        Task<User?> GetUserByIdAsync(int id);
        Task<User?> GetUserByUsernameAsync(string username);

        Task<User?> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
    }
}
