using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolControl.Core.Entities
{
    public class ProfessorCourseEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProfessorEntity))]
        public int ProfessorId { get; set; }
        public virtual ProfessorEntity Professor { get; set; }

        [ForeignKey(nameof(CourseEntity))]
        public int CourseId { get; set; }
        public virtual CourseEntity Course { get; set; }

        [ForeignKey(nameof(GroupEntity))]
        public int GroupId { get; set; }
        public virtual GroupEntity Group { get; set; }

        [ForeignKey(nameof(PeriodEntity))]
        public int PeriodId { get; set; }
        public virtual PeriodEntity Period { get; set; }
    }
}
