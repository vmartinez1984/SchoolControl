using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolControl.Core.Entities;

namespace SchoolControl.Repository.Db.Contexts
{
    public class AppDbContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<CourseEntity> Course { get; set; }
        public DbSet<CurriculumEntity> Curriculum { get; set; }
        public DbSet<GroupEntity> Group { get; set; }
        public DbSet<GroupStudent> GroupStudent { get; set; }
        public DbSet<PeriodEntity> Period { get; set; }
        public DbSet<ProfessorCourseEntity> ProfessorCourse { get; set; }
        public DbSet<ProfessorEntity> Professor { get; set; }
        public DbSet<StudentEntity> Student { get; set; }

        public AppDbContext()
        {

        }

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString;

                connectionString = _configuration.GetConnectionString("SqlServer");
                //connectionString = "Server=localhost;Database=School;Trusted_Connection=True; TrustServerCertificate=True";
                //win
                //connectionString = "Server=localhost; Port=3306; Database=HelpDesk; Uid=root; Pwd=;";
                //optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

                //connectionString = "Server=192.168.1.66; Database=Helpdesk; user id=sa; pwd=macross#7";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
