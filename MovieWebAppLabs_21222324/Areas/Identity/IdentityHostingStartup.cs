using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieWebAppLabs_21222324.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MovieWebAppLabs_21222324.Areas.Identity.IdentityHostingStartup))]
namespace MovieWebAppLabs_21222324.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MovieWebAppLabs_21222324IdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MovieWebAppLabs_21222324IdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MovieWebAppLabs_21222324IdentityDbContext>();
            });
        }
    }
}