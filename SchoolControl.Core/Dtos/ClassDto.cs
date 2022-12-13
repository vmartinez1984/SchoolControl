namespace SchoolControl.Core.Dtos
{
    public class ClassDto : ClassDtoIn
    {
        public string Id { get; set; }
    }

    public class ClassDtoIn
    {
        public string Name { get; set; }

        public string Level { get; set; }

        public int Credits { get; set; }

        public string Curriculum { get; set; }
    }
}