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
            service.AddScoped<ICourseRepository, CourseRepositoryDb>();
            service.AddScoped<ICurriculumRepository, CurriculumRepositoryDb>();
            service.AddScoped<IGroupRepository, GroupRepository>();
            service.AddScoped<IPeriodRepository, PeriodRepositoryDb>();
            service.AddScoped<IProfessorRepository, ProfessorRepository>();
            service.AddScoped<ISchoolControlRepositoryDb, SchoolControlRepositoryDb>();
        }
    }
}
