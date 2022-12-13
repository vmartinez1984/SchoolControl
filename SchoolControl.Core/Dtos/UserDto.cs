namespace SchoolControl.Core.Dtos
{
    public class UserDtoIn : UserDto
    {
        public string Id { get; set; }
    }

    public class UserDto : LoginDto
    {
        public string Name { get; set; }

        public string LastName { get; set; }

    }

    public class LoginDto
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}