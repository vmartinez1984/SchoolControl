using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class CourseBl : BaseBl, ICourseBl
    {
        public CourseBl(ISchoolControlRepositoryDb schoolControlRepositoryDb, IMapper mapper) : base(schoolControlRepositoryDb, mapper)
        {
        }

        public async Task<PagerDto> GetAsync(PagerDto pager)
        {
            PagerEntity pagerEntity;
            List<CourseEntity> entities;

            pagerEntity = _mapper.Map<PagerEntity>(pager);
            entities = await _schoolControlRepositoryDb.Course.GetAsync(pagerEntity);
            pager = _mapper.Map<PagerDto>(pagerEntity);
            pager.List = _mapper.Map<List<CourseDto>>(entities);

            return pager;
        }

        public async Task<int> AddAsync(CourseDtoIn dtoIn)
        {
            CourseEntity entity;

            entity = _mapper.Map<CourseEntity>(dtoIn);
            await _schoolControlRepositoryDb.Course.AddAsync(entity);

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _schoolControlRepositoryDb.Course.DeleteAsync(id);
        }

        public async Task<CourseDto> GetAsync(int id)
        {
            CourseEntity entity;
            CourseDto item;

            entity = await _schoolControlRepositoryDb.Course.GetAsync(id);
            item = _mapper.Map<CourseDto>(entity);

            return item;
        }

        public async Task UpdateAsync(int id, CourseDtoIn dto)
        {
            CourseEntity entity;

            entity = await _schoolControlRepositoryDb.Course.GetAsync(id);
            entity.CurriculumId = dto.CurriculumId;
            entity.Description = dto.Description;
            entity.Credits = dto.Credits;
            entity.Level = dto.Level;
            entity.Credits = dto.Credits;
            entity.Notes = dto.Notes;   

            await _schoolControlRepositoryDb.Course.UpdateAsync(entity);
        }        
    }
}
