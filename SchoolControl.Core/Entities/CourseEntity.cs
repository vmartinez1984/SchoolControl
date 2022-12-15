using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolControl.Core.Entities
{
    public class CourseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
                
        [StringLength(150)]
        public string Description { get; set; }

        [ForeignKey(nameof(CurriculumEntity))]
        public int CurriculumId { get; set; }

        public virtual CurriculumEntity Curriculum { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }
                
        public int Credits { get; set; }

        public int Level { get; set; }

        public DateTime DateRegistration { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}