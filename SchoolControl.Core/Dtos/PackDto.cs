namespace SchoolControl.Core.Dtos
{
    public class PackDto: PackDetailDtoIn
    {
        public string Id { get; set; }
    }

    public class PackDtoIn
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<PackDetailDto> ListPackDetails { get; set; }
    }
}