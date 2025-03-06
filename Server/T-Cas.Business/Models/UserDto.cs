
namespace T_Cas.Business.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public MicUserDto? MicUser { get; set; }
        public required RoleDto Role { get; set; }
    }
}