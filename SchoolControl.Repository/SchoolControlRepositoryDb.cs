using SchoolControl.Core.Interfaces;

namespace SchoolControl.Repository.Db
{
    public class SchoolControlRepositoryDb : ISchoolControlRepositoryDb
    {
        public SchoolControlRepositoryDb(IPeriodRepository period)
        {
            Period = period;
        }

        public IPeriodRepository Period { get; set; }
    }
}
