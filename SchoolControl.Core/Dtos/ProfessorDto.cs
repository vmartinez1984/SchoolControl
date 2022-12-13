namespace SchoolControl.Core.Dtos
{
    public class ProfessorDto
    {
        public string Id { get; set; }
    }

    public class ProfessorDtoIn: StudentDtoIn
    {
        public string Abstract { get; set; }

        public string RouteCv { get; set; }

        public string Note { get; set; }
    }
}