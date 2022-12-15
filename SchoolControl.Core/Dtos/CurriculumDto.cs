using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class CurriculumDto: CurriculumDtoIn
    {
        public int Id { get; set; }
    }

    public class CurriculumDtoIn
    {
        [Required]
        [StringLength(50)]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [StringLength(150)]
        [Display(Name="Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime DateRegistration { get; set; } = DateTime.Now;
    }
}
