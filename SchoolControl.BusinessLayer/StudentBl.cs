using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class StudentBl : BaseBl, IStudentBl
    {
        public StudentBl(ISchoolControlRepositoryDb schoolControlRepositoryDb, IMapper mapper) : base(schoolControlRepositoryDb, mapper)
        {
        }

        public Task<int> AddAsync(StudentDtoIn dtoIn)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public PagerDto GetAsync(PagerDto pagerDto)
        {
            throw new NotImplementedException();
        }

        public Task<StudentDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, StudentDtoIn dtoIn)
        {
            throw new NotImplementedException();
        }
    }
}
