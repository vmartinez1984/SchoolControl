using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Dtos
{
    public class CourseDto : CourseDtoIn
    {
        public string Id { get; set; }

        [Display(Name = "Fecha de registro", ShortName = "Fecha")]
        public DateTime DateRegistration { get; set; }
    }

    public class CourseDtoIn
    {
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [StringLength(150)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El plan de estudios es obligatorio")]
        [Display(Name = "Plan de estudios")]
        public int CurriculumId { get; set; }


        [StringLength(1000)]
        [Display(Name = "Notas")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Número de créditos es obligatorio")]
        [Range(1, 10, ErrorMessage = "El número debe de estar entre {0} y {1}")]
        [Display(Name = "Créditos")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio")]
        [Range(1, 15, ErrorMessage = "El número debe de estar entre {0} y {1}")]
        [Display(Name = "Nivel")]
        public int Level { get; set; }        
    }
}