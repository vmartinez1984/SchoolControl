using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Entities
{
    public class ProfessorEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }
                
        public DateTime Birthday { get; set; }

        [StringLength(50)]  
        public string Email { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public DateTime DateRegistration { get; set; }

        public bool IsActive { get; set; }
        public string MobilePhone { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
    }
}
