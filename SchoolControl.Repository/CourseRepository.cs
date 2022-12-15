using Microsoft.EntityFrameworkCore;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;
using SchoolControl.Repository.Db.Contexts;
using System.Linq.Dynamic.Core;

namespace SchoolControl.Repository.Db
{
    public class CourseRepositoryDb : BaseRepositoryDb, ICourseRepository
    {
        public CourseRepositoryDb(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<CourseEntity>> GetAsync(PagerEntity pager)
        {
            List<CourseEntity> list;
            IQueryable<CourseEntity> queryable;

            queryable = _appDbContext.Course;
            queryable = queryable.Where(x => x.IsActive);
            pager.TotalRecords = queryable.Count();
            if (string.IsNullOrEmpty(pager.Search) == false)
                queryable = queryable.Where(
                    x => string.Concat(x.Name).Contains(pager.Search)
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

        public async Task<int> AddAsync(CourseEntity entity)
        {
            await _appDbContext.Course.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            CourseEntity entity;

            entity = await _appDbContext.Course.Where(x => x.Id == id).FirstOrDefaultAsync();
            entity.IsActive = false;
            _appDbContext.Course.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<CourseEntity> GetAsync(int id)
        {
            CourseEntity entity;

            entity = await _appDbContext.Course.Where(x => x.Id == id).FirstOrDefaultAsync();

            return entity;
        }

        public async Task UpdateAsync(CourseEntity entity)
        {
            _appDbContext.Course.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }
    }
}
