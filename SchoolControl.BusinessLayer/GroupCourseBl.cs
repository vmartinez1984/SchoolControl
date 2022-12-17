using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class GroupCourseBl :BaseBl, IGroupCourseBl
    {
        public GroupCourseBl(ISchoolControlRepositoryDb schoolControlRepositoryDb, IMapper mapper) : base(schoolControlRepositoryDb, mapper)
        {
        }

        public Task<int> AddAsync(GroupCourseDtoIn dtoIn)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagerDto> GetAsync(PagerDto pagerDto)
        {
            throw new NotImplementedException();
        }

        public Task<GroupCourseDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, GroupCourseDtoIn dtoIn)
        {
            throw new NotImplementedException();
        }
    }
}
