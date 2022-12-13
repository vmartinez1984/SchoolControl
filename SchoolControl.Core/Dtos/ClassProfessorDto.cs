namespace SchoolControl.Core.Dtos
{
    public class ClassProfessorDto: ClassProfessorDtoIn
    {
        public string Id { get; set; }
    }

    public class ClassProfessorDtoIn
    {
        public ClassDto Class { get; set; }

        public ProfessorDto ProfessorDto { get; set; }

        public string Period { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateStop { get; set; }

        public string Schedule { get; set; }
    }
}