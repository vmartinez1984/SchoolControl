using Microsoft.EntityFrameworkCore;
using SchoolControl.Core.Entities;
using SchoolControl.Core.Interfaces;
using SchoolControl.Repository.Db.Contexts;
using System.Linq.Dynamic.Core;

namespace SchoolControl.Repository.Db
{
    public class GroupRepository : BaseRepositoryDb, IGroupRepository
    {
        public GroupRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<int> AddAsync(GroupEntity entity)
        {
            await _appDbContext.Group.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            GroupEntity entity;

            entity = await _appDbContext.Group.Where(x => x.Id == id).FirstOrDefaultAsync();
            entity.IsActive = false;
            _appDbContext.Group.Update(entity);

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<GroupEntity>> GetAsync(PagerEntity pager)
        {
            List<GroupEntity> list;
            IQueryable<GroupEntity> queryable;

            queryable = _appDbContext.Group;
            queryable = queryable.Where(x => x.IsActive);
            pager.TotalRecords = queryable.Count();
            if (string.IsNullOrEmpty(pager.Search) == false)
                queryable = queryable.Where(
                    x => string.Concat(x.Name, " ", x.Level).Contains(pager.Search)
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

        public Task<GroupEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(GroupEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
