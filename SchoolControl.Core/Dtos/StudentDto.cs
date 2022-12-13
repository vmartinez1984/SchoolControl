namespace SchoolControl.Core.Dtos
{
    public class StudentDto: StudentDtoIn
    {
        public string Id { get; set; }
    }

    public class StudentDtoIn
    {
        public string Name { get; set; }

        public string LastName1 { get; set; }

        public string LastName2 { get; set; }

        public AddressDto Address { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public List<ClassStudentDto> ListClasses { get; set; }
    }
}