using Microsoft.Extensions.DependencyInjection;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.BusinessLayer.Extensions
{
    public static class SchoolControlExtension
    {
        public static void AddSchoolBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<ICurriculumBl,CurriculumBl>();
            services.AddScoped<ICourseBl, CourseBl>();
            services.AddScoped<IGroupBl, GroupBl>();
            services.AddScoped<IGroupCourseBl, GroupCourseBl>();
            services.AddScoped<IPeriodBl,PeriodBl>();
            services.AddScoped<IProfessorBl,ProfessorBl>();
            services.AddScoped<ISchoolControlBl, SchoolControlBl>();
            services.AddScoped<IStudentBl, StudentBl>();
        }
    }
}