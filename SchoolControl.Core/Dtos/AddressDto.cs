namespace SchoolControl.Core.Dtos
{
    public class AddressDto: AddressDtoIn
    {
        public string Id { get; set; }

        public DateTime DateRegistration { get; set; }
    }

    public class AddressDtoIn
    {
        public string StreetAndNumber { get; set; }

        public string Colonia { get; set; }

        public string Alcaldia { get; set; }

        public string Estado { get; set; }

        public string CodigoPostal { get; set; }
    }
}