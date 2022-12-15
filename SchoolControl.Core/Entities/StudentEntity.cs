using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Entities
{
    public class StudentEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime DateRegistration { get; set; }

        public bool IsActive { get; set; }

    }
}