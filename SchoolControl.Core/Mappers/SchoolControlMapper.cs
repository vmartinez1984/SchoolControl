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
                        
            CreateMap<CourseEntity, CourseDto>();
            CreateMap<CourseDtoIn, CourseEntity>();

            CreateMap<GroupDtoIn, GroupEntity>();
            CreateMap<GroupEntity, GroupDto>();

            CreateMap<PagerEntity, PagerDto>().ReverseMap();
            CreateMap<ProfessorDtoIn, ProfessorEntity>();
            CreateMap<ProfessorEntity, ProfessorDto>();

        }
    }
}
