using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControl.BusinessLayer
{
    public class GroupBl : BaseBl, IGroupBl
    {
        public GroupBl(ISchoolControlRepositoryDb schoolControlRepositoryDb, IMapper mapper) : base(schoolControlRepositoryDb, mapper)
        {
        }

        public async Task<int> AddAsync(GroupDtoIn dtoIn)
        {
            GroupEntity entity;

            entity = _mapper.Map<GroupEntity>(dtoIn);
            await _schoolControlRepositoryDb.Group.AddAsync(entity);

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _schoolControlRepositoryDb.Course.DeleteAsync(id);
        }

        public async Task<PagerDto> GetAsync(PagerDto pager)
        {
            PagerEntity pagerEntity;
            List<GroupEntity> entities;

            pagerEntity = _mapper.Map<PagerEntity>(pager);
            entities = await _schoolControlRepositoryDb.Group.GetAsync(pagerEntity);
            pager = _mapper.Map<PagerDto>(pagerEntity);
            pager.List = _mapper.Map<List<GroupDto>>(entities);

            return pager;
        }

        public Task<GroupDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, GroupDtoIn dtoIn)
        {
            throw new NotImplementedException();
        }
    }
}
