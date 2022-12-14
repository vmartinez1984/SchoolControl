namespace SchoolControl.Repository.Db.Contexts
{
    public  class BaseRepositoryDb
    {
        public readonly AppDbContext _appDbContext;

        public BaseRepositoryDb(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
