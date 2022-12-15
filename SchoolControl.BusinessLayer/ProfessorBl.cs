using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class ProfessorBl : BaseBl, IProfessorBl
    {
        public ProfessorBl(ISchoolControlRepositoryDb schoolControlRepositoryDb, IMapper mapper) : base(schoolControlRepositoryDb, mapper)
        {
        }

        public async Task<int> AddAsync(ProfessorDtoIn dtoIn)
        {
            ProfessorEntity entity;

            entity = _mapper.Map<ProfessorEntity>(dtoIn);
            await _schoolControlRepositoryDb.Professor.AddAsync(entity);

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _schoolControlRepositoryDb.Professor.DeleteAsync(id);
        }

        public async Task<PagerDto> GetAsync(PagerDto pager)
        {
            PagerEntity pagerEntity;
            List<ProfessorEntity> entities;

            pagerEntity = _mapper.Map<PagerEntity>(pager);
            entities = await _schoolControlRepositoryDb.Professor.GetAsync(pagerEntity);
            pager = _mapper.Map<PagerDto>(pagerEntity);
            pager.List = _mapper.Map<List<ProfessorDto>>(entities);

            return pager;
        }

        public async Task<ProfessorDto> GetAsync(int id)
        {
            ProfessorEntity entity;
            ProfessorDto item;

            entity = await _schoolControlRepositoryDb.Professor.GetAsync(id);
            item = _mapper.Map<ProfessorDto>(entity);

            return item;
        }

        public async Task UpdateAsync(int id, ProfessorDtoIn dto)
        {
            ProfessorEntity entity;

            entity = await _schoolControlRepositoryDb.Professor.GetAsync(id);
            entity.Name = dto.Name;
            entity.LastName1 = dto.LastName1;
            entity.LastName2 = dto.LastName2;
            entity.Birthday = dto.Birthday;
            entity.MobilePhone = dto.MobilePhone;
            entity.Note = dto.Note;
            entity.Email = dto.Email;

            _schoolControlRepositoryDb.Professor.UpdateAsync(entity);
        }
    }
}
