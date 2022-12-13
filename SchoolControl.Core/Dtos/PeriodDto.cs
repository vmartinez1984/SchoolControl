namespace SchoolControl.Core.Dtos
{
    public class PeriodDto: PeriodDtoIn
    {
        public int Id { get; set; }

    }
    public class PeriodDtoIn
    {        
        public string Name { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateStop { get; set; }
    }
}