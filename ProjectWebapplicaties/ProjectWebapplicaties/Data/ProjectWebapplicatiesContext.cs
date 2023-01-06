using Microsoft.EntityFrameworkCore;
using ProjectWebapplicaties.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProjectWebapplicaties.Areas.Identity.Data;

namespace ProjectWebapplicaties.Data
{
    public class ProjectWebapplicatiesContext : IdentityDbContext<CustomUser>
    {
        public ProjectWebapplicatiesContext(DbContextOptions<ProjectWebapplicatiesContext> options) : base(options)
        {

        }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Medewerker> Medewerkers { get; set; }
        public DbSet<Bestelling> Bestellingen { get; set; }
        public DbSet<Status> Statussen { get; set; }
        public DbSet<PizzaGrootte> PizzaGroottes { get; set; }
        public DbSet<BestellingPizza> BestellingPizzas { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Klant>().ToTable("Klanten");
            modelBuilder.Entity<Medewerker>().ToTable("Medewerkers");
            modelBuilder.Entity<Bestelling>().ToTable("Bestellingen");
            modelBuilder.Entity<Status>().ToTable("Statussen");
            modelBuilder.Entity<PizzaGrootte>().ToTable("PizzaGroottes");
            modelBuilder.Entity<BestellingPizza>().ToTable("BestellingPizzas");
            modelBuilder.Entity<Pizza>().ToTable("Pizzas");
        }
    }
}
