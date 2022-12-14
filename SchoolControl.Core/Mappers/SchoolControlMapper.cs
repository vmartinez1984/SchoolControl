using AutoMapper;
using SchoolControl.Core.Dtos;

namespace SchoolControl.Core.Mappers
{
    public class SchoolControlMapper: Profile
    {
        public SchoolControlMapper()
        {
            CreateMap<PeriodEntity,PeriodDto>();
        }
    }
}
