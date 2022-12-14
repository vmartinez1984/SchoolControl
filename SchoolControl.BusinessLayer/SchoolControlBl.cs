using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer;
public class SchoolControlBl : ISchoolControlBl
{
    public SchoolControlBl(        
       // IStudentBl student
        IPeriodBl period
    )
    {
       // Student = student;
        Period = period;
    }

   // public IStudentBl Student { get; set; }
    public IPeriodBl Period { get; set; }
}
