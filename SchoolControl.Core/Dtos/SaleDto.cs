namespace SchoolControl.Core.Dtos
{
    public class SaleDto
    {
        public string Id { get; set; }
    }

    public class SaleDtoIn
    {
        public PackDto Pack { get; set; }

        public decimal Price { get; set; }

        public decimal Pay { get; set; }
    }
}