using SchoolControl.Core.Entities;

namespace SchoolControl.Core.Interfaces
{
    public interface ISchoolControlRepositoryDb
    {
        public ICourseRepository Course { get; set; }

        public ICurriculumRepository Curriculum { get; set; }

        public IGroupRepository Group { get; set; }

        public IPeriodRepository Period { get; set; }

        public IProfessorCourseRepository ProfessorCourse { get; set; }

        public IProfessorRepository Professor { get; set; }

        public IStudent Student { get; set; }
    }

    public interface IBase<T>
    {
        Task<T> GetAsync(int id);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);

        Task<int> AddAsync(T entity);
    }

    public interface ICourseRepository : IBase<CourseEntity>
    {
        Task<List<CourseEntity>> GetAsync(PagerEntity pager);
    }
    public interface ICurriculumRepository : IBase<CurriculumEntity>
    {
        Task<List<CurriculumEntity>> GetAsync();
    }
    public interface IGroupRepository : IBase<GroupEntity> { }
    public interface IPeriodRepository : IBase<PeriodEntity>
    {
        Task<List<PeriodEntity>> GetAsync();
    }
    public interface IProfessorCourseRepository : IBase<ProfessorCourseEntity> { }
    public interface IProfessorRepository : IBase<ProfessorEntity>
    {
        Task<List<ProfessorEntity>> GetAsync(PagerEntity pager);
    }
    public interface IStudent : IBase<StudentEntity> { }
}
