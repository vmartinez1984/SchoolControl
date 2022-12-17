using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class GroupDto: GroupDtoIn
    {
        public int Id { get; set; }

        public DateTime DateRegistration { get; set; }
    }

    public class GroupDtoIn
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Display(Name = "Grado")]
        public int Level { get; set; }
    }
}
