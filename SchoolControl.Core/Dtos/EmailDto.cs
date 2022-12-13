namespace SchoolControl.Core.Dtos
{
    public class EmailDto: EmailDtoIn
    {
        public string Id { get; set; }
    }

    public class EmailDtoIn
    {
        public string Email { get; set; }            
    }
}