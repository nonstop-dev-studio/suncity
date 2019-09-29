using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using suncity.web.Models;
using Suncity.Web.Models;

namespace Suncity.Web.Context
{
    public class SuncityContext : IdentityDbContext<User>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}
        public SuncityContext(DbContextOptions<SuncityContext> options) : base(options) { }
        public SuncityContext(){}

        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ChatConnection> ChatConnections { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<IdentityRole> IdentityRole { get; set; }
        //public DbSet<IdentityUserRole<string>> IdentityUserRole { get; set; }
    }
}