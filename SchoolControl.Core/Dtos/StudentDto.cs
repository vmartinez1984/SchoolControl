using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class StudentDto: StudentDtoIn
    {
        public string Id { get; set; }
    }

    public class StudentDtoIn
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Apellido paterno")]
        public string LastName1 { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido materno")]
        public string LastName2 { get; set; }

        public AddressDto Address { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(10)]
        [Display(Name = "Celular")]
        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Correo")]
        public string Email { get; set; }        
    }
}