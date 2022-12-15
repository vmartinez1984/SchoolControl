using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class CurriculumBl : BaseBl, ICurriculumBl
    {
        public CurriculumBl(ISchoolControlRepositoryDb schoolControlRepositoryDb, IMapper mapper) : base(schoolControlRepositoryDb, mapper)
        {
        }

        public async Task<List<CurriculumDto>> GetAsync()
        {
            List<CurriculumDto> list;
            List<CurriculumEntity> entities;

            entities = await _schoolControlRepositoryDb.Curriculum.GetAsync();
            list = _mapper.Map<List<CurriculumDto>>(entities);    

            return list;
        }

        public async Task<int> AddAsync(CurriculumDtoIn dtoIn)
        {
            CurriculumEntity entity;

            entity = _mapper.Map<CurriculumEntity>(dtoIn);
            await _schoolControlRepositoryDb.Curriculum.AddAsync(entity);

            return entity.Id;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CurriculumDto> GetAsync(int id)
        {
            CurriculumDto item;
            CurriculumEntity entity;

            entity = await _schoolControlRepositoryDb.Curriculum.GetAsync(id);
            item = _mapper.Map<CurriculumDto>(entity);

            return item;
        }

        public Task UpdateAsync(int id, CurriculumDtoIn dtoIn)
        {
            throw new NotImplementedException();
        }
    }
}
