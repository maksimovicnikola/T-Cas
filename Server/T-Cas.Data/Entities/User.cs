
namespace T_Cas.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int? MicUserId { get; set; }
        public MicUser? MicUser { get; set; }
        public int RoleId { get; set; }
        public required Role Role { get; set; }
    }
}
