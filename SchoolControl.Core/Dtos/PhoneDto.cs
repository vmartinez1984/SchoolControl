namespace SchoolControl.Core.Dtos
{
    public class PhoneDto: PhoneDtoIn
    {
        public string Id { get; set; }
    }

    public class PhoneDtoIn
    {
        public string Number { get; set; }

        public string Type { get; set; }

        public string Note { get; set; }
    }
}