using Microsoft.EntityFrameworkCore;

using Suncity.Web.Models;

namespace Suncity.Web.Context
{
    public class SuncityContext : DbContext
    {
        public SuncityContext(DbContextOptions<SuncityContext> options) : base(options) { }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
}
}