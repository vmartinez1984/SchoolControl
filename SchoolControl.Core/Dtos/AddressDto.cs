using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class AddressDto: AddressDtoIn
    {
        public string Id { get; set; }

        public DateTime DateRegistration { get; set; }
    }

    public class AddressDtoIn
    {
        [Display(Name = "Calle y número")]
        public string StreetAndNumber { get; set; }

        [Display(Name ="Colonia")]
        public string Colonia { get; set; }

        [Display(Name = "Alcaldia")]
        public string Alcaldia { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Código postal")]
        public string CodigoPostal { get; set; }
    }
}