using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControl.BusinessLayer
{
    public class PeriodBl : BaseBl, IPeriodBl
    {
        public PeriodBl(ISchoolControlRepositoryDb repositoryDb, IMapper mapper) : base(repositoryDb, mapper)
        {
        }

        public Task<int> AddAsync(PeriodDto periodDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PeriodDto>> GetAsync()
        {
            List<PeriodDto> list;
            List<PeriodEntity> entities;

            entities = await _repositoryDb.Period.GetAsync();
            list = _mapper.Map<List<PeriodDto>>(entities);

            return list;
        }
    }
}
