using SchoolControl.Core.Dtos;

namespace SchoolControl.Core.Interfaces;

public interface IBusinessLayer
{
    public IStudentBl Student { get; set; }

    public IPeriodBl Period { get; set; }
}

public interface IPeriodBl
{
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

public interface IProfessor
{

}