namespace SchoolControl.Core.Dtos
{
    public class QualificationDto: QualificationDtoIn
    {
        public string Id { get; set; }
    }

    public class QualificationDtoIn
    {
        public CourseDto Class { get; set; }

        public ProfessorDto Professor { get; set; }

        public decimal Qualification { get; set; }

        public DateTime DateRegistration { get; set; }
    }
}