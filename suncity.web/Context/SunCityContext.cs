using Microsoft.EntityFrameworkCore;
using suncity.web.Models.User;
using Suncity.Web.Models;

namespace Suncity.Web.Context
{
    public class SuncityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NonStopVkHack;Username=postgres;Password=password");
        }

        public SuncityContext(DbContextOptions<SuncityContext> options) : base(options) { }

        public SuncityContext()
        {
        }

        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<SunCityUser> Users { get; set; }
    }
}