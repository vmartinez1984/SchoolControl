using Microsoft.EntityFrameworkCore;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;
using SchoolControl.Repository.Db.Contexts;
using System.Linq.Dynamic.Core;

namespace SchoolControl.Repository.Db
{
    public class ProfessorRepository : BaseRepositoryDb, IProfessorRepository
    {
        public ProfessorRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<ProfessorEntity>> GetAsync(PagerEntity pager)
        {
            List<ProfessorEntity> list;
            IQueryable<ProfessorEntity> queryable;

            queryable = _appDbContext.Professor;
            queryable = queryable.Where(x => x.IsActive);
            pager.TotalRecords = queryable.Count();
            if (string.IsNullOrEmpty(pager.Search) == false)
                queryable = queryable.Where(
                    x => string.Concat(x.Name, " ", x.LastName, " ", x.Email).Contains(pager.Search)
                );
            if (string.IsNullOrEmpty(pager.SortColumn) == false && string.IsNullOrEmpty(pager.SortColumnDir) == false)
            {
                queryable = queryable.OrderBy(pager.SortColumn + " " + pager.SortColumnDir);
            }
            list = await queryable
            .OrderByDescending(x => x.Id)
            .Skip((pager.PageCurrent - 1) * pager.RecordsPerPage)
            .Take(pager.RecordsPerPage)
            .ToListAsync();
            pager.TotalRecords = await queryable.CountAsync();
            list = await queryable.ToListAsync();
            pager.TotalRecordsFiltered = await queryable.CountAsync();

            return list;
        }

        public async Task<int> AddAsync(ProfessorEntity entity)
        {
            await _appDbContext.Professor.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            ProfessorEntity entity;

            entity = await _appDbContext.Professor.Where(x => x.Id == id).FirstOrDefaultAsync();
            entity.IsActive = false;
            _appDbContext.Professor.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<ProfessorEntity> GetAsync(int id)
        {
            ProfessorEntity entity;

            entity = await _appDbContext.Professor.Where(x => x.Id == id).FirstOrDefaultAsync();

            return entity;
        }

        public async Task UpdateAsync(ProfessorEntity entity)
        {
            _appDbContext.Professor.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }
    }
}