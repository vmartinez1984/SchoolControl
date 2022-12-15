using SchoolControl.Core.Dtos;

namespace SchoolControl.Core.Interfaces;

public interface ISchoolControlBl
{
    ICourseBl Course { get; set; }
    // public IStudentBl Student { get; set; }

    public IPeriodBl Period { get; set; }

    IProfessorBl Professor { get; set; }
    ICurriculumBl Curriculum { get; set; }
}

public interface IBaseBl<U, T>
{
    Task<int> AddAsync(U dtoIn);

    Task<T> GetAsync(int id);

    Task DeleteAsync(int id);

    Task UpdateAsync(int id, U dtoIn);
}

public interface ICurriculumBl : IBaseBl<CurriculumDtoIn, CurriculumDto>
{
    Task<List<CurriculumDto>> GetAsync();
}

public interface ICourseBl : IBaseBl<CourseDtoIn, CourseDto>
{
    Task<PagerDto> GetAsync(PagerDto pagerDto);    
}

public interface IPeriodBl
{
    Task<int> AddAsync(PeriodDto periodDto);
    Task<List<PeriodDto>> GetAsync();
}

public interface IStudentBl
{
    Task<StudentDto> GetAsync(string studentId);

    Task<List<StudentDto>> GetByGroupAsync(string groupId);

    Task<List<StudentDto>> GetByCourseAsync(string courseId);

    Task UpdateAsync(string studentId, StudentDtoIn studentDtoIn);

    Task<string> AddAsync(StudentDtoIn studentDtoIn);
}

public interface IProfessorBl : IBaseBl<ProfessorDtoIn, ProfessorDto>
{
    Task<PagerDto> GetAsync(PagerDto pagerDto);
}