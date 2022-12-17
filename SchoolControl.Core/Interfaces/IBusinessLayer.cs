using SchoolControl.Core.Dtos;

namespace SchoolControl.Core.Interfaces;

public interface ISchoolControlBl
{
    ICourseBl Course { get; }

    IPeriodBl Period { get; }

    IProfessorBl Professor { get; }
    
    ICurriculumBl Curriculum { get;  }
    
    IGroupBl Group { get;  }
    
    IGroupCourseBl GroupCourse { get; }
    
    IStudentBl Student { get; set; }
}

public interface IBaseBl<U, T>
{
    Task<int> AddAsync(U dtoIn);

    Task<T> GetAsync(int id);

    Task DeleteAsync(int id);

    Task UpdateAsync(int id, U dtoIn);
}

public interface IGroupBl: IBaseBl<GroupDtoIn, GroupDto>
{
    Task<PagerDto> GetAsync(PagerDto pagerDto);
}

public interface IGroupCourseBl : IBaseBl<GroupCourseDtoIn, GroupCourseDto>
{
    Task<PagerDto> GetAsync(PagerDto pagerDto);
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

public interface IStudentBl : IBaseBl<StudentDtoIn, StudentDto>
{
    PagerDto GetAsync(PagerDto pagerDto);
}

public interface IProfessorBl : IBaseBl<ProfessorDtoIn, ProfessorDto>
{
    Task<PagerDto> GetAsync(PagerDto pagerDto);
}