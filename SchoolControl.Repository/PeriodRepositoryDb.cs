using Microsoft.EntityFrameworkCore;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;
using SchoolControl.Repository.Db.Contexts;

namespace SchoolControl.Repository.Db
{
    public class PeriodRepositoryDb : BaseRepositoryDb, IPeriodRepository
    {
        public PeriodRepositoryDb(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<int> AddAsync(PeriodEntity entity)
        {
            _appDbContext.Period.Add(entity);
            await _appDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public Task<PeriodEntity> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PeriodEntity>> GetAsync()
        {
            List<PeriodEntity> list;

            list = await _appDbContext.Period.ToListAsync();

            return list;
        }

        public Task<PeriodEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PeriodEntity> UpdateAsync(PeriodEntity entity)
        {
            throw new NotImplementedException();
        }

        Task IBase<PeriodEntity>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IBase<PeriodEntity>.UpdateAsync(PeriodEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
