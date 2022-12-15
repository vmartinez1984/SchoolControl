using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolControl.Core.Entities
{
    public class GroupStudent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(GroupEntity))]
        public int GroupId { get; set; }
        public virtual GroupEntity Group { get; set; }

        [ForeignKey(nameof(StudentEntity))]
        public int StudentId { get; set; }
        public virtual StudentEntity Student { get; set; }
        public DateTime DateRegistration { get; set; }

        public bool IsActive { get; set; }
    }
}