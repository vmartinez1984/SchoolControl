using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class ProfessorDto: ProfessorDtoIn
    {
        public string Id { get; set; }

        public DateTime DateRegistration { get; set; }
    }

    public class ProfessorDtoIn
    {
        [Required(ErrorMessage ="Nombre obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Apellido obligatorio")]
        [Display(Name = "Apellido Paterno")]
        [StringLength(50)]
        public string LastName1 { get; set; }

        [Display(Name = "Apellido Materno")]
        public string LastName2 { get; set; }
        public IFormFile Cv { get; set; }

        public IFormFile Photo { get; set; }

        [StringLength(200)]
        [Display(Name = "Notas")]
        public string Note { get; set; }

        [Display(Name= "Fecha de nacimiento")]
        public DateTime Birthday { get; set; }

        public AddressDto Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
    }
}