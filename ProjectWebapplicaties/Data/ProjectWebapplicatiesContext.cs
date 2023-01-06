using Microsoft.EntityFrameworkCore;
using ProjectWebapplicaties.Models;

namespace ProjectWebapplicaties.Data
{
    public class ProjectWebapplicatiesContext : DbContext
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
