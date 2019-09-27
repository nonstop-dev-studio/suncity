using Microsoft.EntityFrameworkCore;
using suncity.web.Infrostructure;
using suncity.web.Models.User;
using Suncity.Web.Models;
using System.Threading.Tasks;

namespace Suncity.Web.Context
{
    public class SuncityContext : DbContext
    {
        public SuncityContext(DbContextOptions<SuncityContext> options) : base(options) { }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<SunCityUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: DBGlobals.SchemaName);
            modelBuilder.Entity<Report>();
            modelBuilder.Entity<Questionnaire>();
            modelBuilder.Entity<SunCityUser>();
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}