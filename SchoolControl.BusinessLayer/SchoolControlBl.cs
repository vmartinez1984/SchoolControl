using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer;
public class SchoolControlBl : ISchoolControlBl
{
    public SchoolControlBl( 
        ICurriculumBl curriculum,
        ICourseBl courseBl,
        IPeriodBl period,
       // IStudentBl student
       IProfessorBl professorBl
    )
    {
        Curriculum= curriculum;
        Course = courseBl;
        Period = period;
        Professor = professorBl;
       // Student = student;
    }

    public IProfessorBl Professor { get; set; }
    public ICurriculumBl Curriculum { get; set; }

    public ICourseBl Course { get; set; }

    public IPeriodBl Period { get; set; }
    // public IStudentBl Student { get; set; }
}
