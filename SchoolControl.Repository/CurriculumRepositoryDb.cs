using Microsoft.EntityFrameworkCore;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;
using SchoolControl.Repository.Db.Contexts;

namespace SchoolControl.Repository.Db
{
    public class CurriculumRepositoryDb : BaseRepositoryDb, ICurriculumRepository
    {
        public CurriculumRepositoryDb(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<int> AddAsync(CurriculumEntity entity)
        {
            await _appDbContext.Curriculum.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            CurriculumEntity entity;

            entity = await _appDbContext.Curriculum.Where(x => x.Id == id).FirstOrDefaultAsync();
            entity.IsActive = false;
            _appDbContext.Curriculum.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<CurriculumEntity> GetAsync(int id)
        {
            CurriculumEntity entity;

            entity = await _appDbContext.Curriculum.Where(x => x.Id == id).FirstOrDefaultAsync();

            return entity;
        }

        public async Task UpdateAsync(CurriculumEntity entity)
        {
            _appDbContext.Curriculum.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<CurriculumEntity>> GetAsync()
        {
            List<CurriculumEntity> entities;

            entities = await _appDbContext.Curriculum.Where(x=>x.IsActive).ToListAsync();

            return entities;
        }
    }
}
