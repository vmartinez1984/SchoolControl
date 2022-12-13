namespace SchoolControl.Core.Dtos
{
    public class PackDetailDto: PackDetailDtoIn
    {
        public string Id { get; set; }    
    }

    public class PackDetailDtoIn
    {
        public ClassDto Class { get; set; }

        public decimal Price { get; set; }
    }
}