using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolControl.Core.Dtos;

namespace SchoolControl.Repository.Db.Contexts
{
    public class AppDbContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<PeriodEntity> Period { get; set; }
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
                //connectionString = "Server=localhost; Port=13306; Database=HelpDesk; Uid=root; Pwd=;";
                //win
                //connectionString = "Server=localhost; Port=3306; Database=HelpDesk; Uid=root; Pwd=;";
                //optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                
                //connectionString = "Server=192.168.1.66; Database=Helpdesk; user id=sa; pwd=macross#7";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
