using T_Cas.Data.DataContext;
using T_Cas.Data.Entities;
using T_Cas.Data.Repositories.Interfaces;

namespace T_Cas.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {

        private readonly TCasContext _context;

        public async Task<User?> CreateUserAsync(User user)
        {
            var newUser = await _context.Users.AddAsync(user);

            await SaveChangesAsync();

            return newUser.Entity;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            var user = new User
            {
                Id = 1,
                Username = "ied.username",
                FirstName = "IED",
                LastName = "IED",
                PasswordHash = "ied.password",
                RoleId = getMockRole().Id,
                Role = getMockRole()
            };

            return await Task.FromResult(user);
        }

        private Role getMockRole()
        {
            var role = new Role
            {
                Id = 1,
                Name = "Admin"
            };

            return role;
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }
        public async Task<User?> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }


        private async Task<bool> SaveChangesAsync()
        {
            return await this._context.SaveChangesAsync() > 0;
        }
    }
}
