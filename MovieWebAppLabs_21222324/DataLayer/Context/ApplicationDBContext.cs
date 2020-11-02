using System;
using Microsoft.EntityFrameworkCore;

namespace MovieWebAppLabs_21222324.DataLayer.Context
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) : base(options) { }

       public DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>(i =>
            {
                i.HasKey(k => k.ID);
                i.HasData(
                    new Movies { ID = 1, Name = "The Little Mermaid", Genre = "Anitmation", Runtime = 1.54 },
                    new Movies { ID = 2, Name = "Pirates of The Caribbean", Genre = "Action", Runtime = 1.54 },
                    new Movies { ID = 3, Name = "When Harry Met Sally", Genre = "Romantic Comedy", Runtime = 1.54 },
                    new Movies { ID = 4, Name = "The Imitation Game", Genre = "Drama", Runtime = 1.54 },
                    new Movies { ID = 5, Name = "Hidden Figures", Genre = "Biopic", Runtime = 1.54 });
        });

            base.OnModelCreating(modelBuilder);
        }
    }
}
