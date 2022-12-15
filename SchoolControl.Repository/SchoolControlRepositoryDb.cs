using SchoolControl.Core.Interfaces;

namespace SchoolControl.Repository.Db
{
    public class SchoolControlRepositoryDb : ISchoolControlRepositoryDb
    {
        public SchoolControlRepositoryDb(
            ICourseRepository course,
            ICurriculumRepository curriculum,
            //IGroupRepository group,
            IPeriodRepository period,
            //IProfessorCourseRepository professorCourse,
            IProfessorRepository professor
            //IStudent student
        )
        {
            Curriculum = curriculum;
            Period = period;
            Professor = professor;
            Course = course;
        }

        public IPeriodRepository Period { get; set; }
        public ICourseRepository Course { get; set; }
        public ICurriculumRepository Curriculum { get; set; }
        public IGroupRepository Group { get; set; }
        public IProfessorCourseRepository ProfessorCourse { get; set; }
        public IProfessorRepository Professor { get; set; }
        public IStudent Student { get; set; }
    }
}
