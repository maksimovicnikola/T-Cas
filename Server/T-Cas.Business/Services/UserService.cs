using AutoMapper;
using T_Cas.Business.Interfaces;
using T_Cas.Business.Models;
using T_Cas.Data.Entities;
using T_Cas.Data.Repositories.Interfaces;

namespace T_Cas.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto?> CreateUserAsync(CreateUserDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            userEntity.PasswordHash = HashPassword(user.Password);

            var createdUser = await _userRepository.CreateUserAsync(userEntity);

            return _mapper.Map<UserDto>(createdUser);
        }
        public async Task<UserDto?> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            return _mapper.Map<UserDto>(user);
        }

        public Task<UserDto?> GetUserByUsernameAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto?> UpdateUserAsync(UpdateUserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        private string HashPassword(string password)
        {
            // Implement your password hashing logic here
            return "HashedPassword";
        }

        private bool VerifyPassword(string storedHash, string password)
        {
            // Implement your password verification logic here
            return true;
        }
    }
}
