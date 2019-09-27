using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using suncity.web.Infrostructure;
using Suncity.Web.Context;

[assembly: HostingStartup(typeof(suncity.web.Areas.Identity.IdentityHostingStartup))]
namespace suncity.web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SuncityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("suncitywebContextConnection")));

                services.AddIdentity<IdentityUser, IdentityRole>()
                // services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<SuncityContext>()
                .AddDefaultTokenProviders();

                // using Microsoft.AspNetCore.Identity.UI.Services;
                services.AddSingleton<IEmailSender, EmailSender>();
            });
        }
    }
}