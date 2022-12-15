using AutoMapper;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Entities;

namespace SchoolControl.Core.Mappers
{
    public class SchoolControlMapper : Profile
    {
        public SchoolControlMapper()
        {
            CreateMap<PeriodEntity, PeriodDto>();

            CreateMap<CurriculumDtoIn, CurriculumEntity>();
            CreateMap<CurriculumEntity, CurriculumDto>();

            CreateMap<PagerEntity, PagerDto>().ReverseMap();
            
            CreateMap<CourseEntity, CourseDto>();
            CreateMap<CourseDtoIn, CourseEntity>();
        }
    }
}
