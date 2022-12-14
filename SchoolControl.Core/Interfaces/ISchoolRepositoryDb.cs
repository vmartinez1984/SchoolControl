using SchoolControl.Core.Dtos;

namespace SchoolControl.Core.Interfaces
{
    public interface ISchoolControlRepositoryDb
    {
        public IPeriodRepository Period { get; set; }
    }

    public interface IPeriodRepository : IBase<PeriodEntity>
    {
        Task<List<PeriodEntity>> GetAsync();
    }


    public interface IBase<T>
    {
        Task<T> GetAsync(int id);

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(int id);

        Task<int> AddAsync(T entity);
    }
}
