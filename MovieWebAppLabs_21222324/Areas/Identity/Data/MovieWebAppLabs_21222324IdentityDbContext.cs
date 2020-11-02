using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MovieWebAppLabs_21222324.Areas.Identity.Data
{
    public class MovieWebAppLabs_21222324IdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public MovieWebAppLabs_21222324IdentityDbContext(DbContextOptions<MovieWebAppLabs_21222324IdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
    public class DesignTimeDBContextFactory : IDesignTimeDbContextFactory<MovieWebAppLabs_21222324IdentityDbContext>
    {
        public MovieWebAppLabs_21222324IdentityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MovieWebAppLabs_21222324IdentityDbContext>();
            builder.UseSqlServer("Server=127.0.0.1;Database=MovieWebApp;User=sa;Password=AnExamplePassword1@");
            return new MovieWebAppLabs_21222324IdentityDbContext(builder.Options);
        }
    }
}

