using Microsoft.EntityFrameworkCore;
using Suncity.Web.Models;
using Suncity.Web.Models.User;

namespace Suncity.Web.Context
{
    public class SuncityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}
        public SuncityContext(DbContextOptions<SuncityContext> options) : base(options) { }
        public SuncityContext(){}

        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SunCityUser> Users { get; set; }

        public DbSet<ChatConnection> ChatConnections { get; set; }
    }
}