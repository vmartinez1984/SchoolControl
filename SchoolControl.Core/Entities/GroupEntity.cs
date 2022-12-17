using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Entities
{
    public class GroupEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(1, 15)]
        public int Level { get; set; }

        public DateTime DateRegistration { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}