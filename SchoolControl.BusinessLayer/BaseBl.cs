using AutoMapper;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class BaseBl
    {
        public readonly ISchoolControlRepositoryDb _schoolControlRepositoryDb;
        public readonly IMapper _mapper;

        public BaseBl(
            ISchoolControlRepositoryDb schoolControlRepositoryDb,
            IMapper mapper
        )
        {
            _schoolControlRepositoryDb = schoolControlRepositoryDb;
            _mapper = mapper;
        }
    }
}
