namespace T_Cas.Business.Models
{
    public class CreateUserDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int? MicUserId { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsIEDUser { get; set; }
    }
}
