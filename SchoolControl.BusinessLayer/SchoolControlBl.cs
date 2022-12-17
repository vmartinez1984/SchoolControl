using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer;
public class SchoolControlBl : ISchoolControlBl
{
    public SchoolControlBl( 
        ICurriculumBl curriculum,
        ICourseBl courseBl,
        IPeriodBl period,
        IGroupBl groupBl,
        IGroupCourseBl groupCourseBl,
        IProfessorBl professorBl,
        IStudentBl student
    )
    {
        Curriculum= curriculum;
        Course = courseBl;
        Group = groupBl;
        GroupCourse = groupCourseBl;
        Period = period;
        Professor = professorBl;
        Student = student;
    }

    public IProfessorBl Professor { get; }

    public ICurriculumBl Curriculum { get; }

    public ICourseBl Course { get; }

    public IPeriodBl Period { get; }

    public IGroupBl Group { get; }

    public IGroupCourseBl GroupCourse { get; }
    
    public IStudentBl Student { get; set; }
}
