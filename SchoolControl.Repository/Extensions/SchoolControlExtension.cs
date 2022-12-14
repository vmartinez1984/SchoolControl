using Microsoft.Extensions.DependencyInjection;
using SchoolControl.Core.Interfaces;
using SchoolControl.Repository.Db.Contexts;

namespace SchoolControl.Repository.Db.Extensions
{
    public static class SchoolControlExtension
    {
        public static void AddRepositoryDb(this IServiceCollection service)
        {
            service.AddScoped<AppDbContext>();
            service.AddScoped<IPeriodRepository, PeriodRepositoryDb>();
            service.AddScoped<ISchoolControlRepositoryDb, SchoolControlRepositoryDb>();
        }
    }
}
