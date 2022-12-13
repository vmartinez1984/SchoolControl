namespace SchoolControl.Core.Dtos
{
    public class ClassStudentDto: ClassProfessorDtoIn
    {
        public string Id { get; set; }
    }

    public class ClassStudentDtoIn
    {
        public string Group { get; set; }

        public string Level { get; set; }

        public string Period { get; set; }

        public ProfessorDto Professor { get; set; }

        public ClassDto Class { get; set; }

        public string Schedule { get; set; }
    }
}