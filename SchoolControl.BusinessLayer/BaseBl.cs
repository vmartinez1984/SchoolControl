using AutoMapper;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer
{
    public class BaseBl
    {
        public readonly ISchoolControlRepositoryDb _repositoryDb;
        public readonly IMapper _mapper;

        public BaseBl(
            ISchoolControlRepositoryDb repositoryDb,
            IMapper mapper
        )
        {
            _repositoryDb = repositoryDb;
            _mapper = mapper;
        }
    }
}
