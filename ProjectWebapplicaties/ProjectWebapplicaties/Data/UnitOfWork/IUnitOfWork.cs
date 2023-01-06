using ProjectWebapplicaties.Data.Repositories.Interfaces;
using ProjectWebapplicaties.Data.Repositories.Repos;
using ProjectWebapplicaties.Models;
using System.Threading.Tasks;

namespace ProjectWebapplicaties.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Bestelling> BestellingRepository { get; }
        IGenericRepository<BestellingPizza> BestellingPizzaRepository { get; }
        IGenericRepository<Klant> KlantRepository { get; }
        IGenericRepository<Medewerker> MedewerkerRepository { get; }
        IGenericRepository<Pizza> PizzaRepository { get; }
        IGenericRepository<PizzaGrootte> PizzaGrootteRepository { get; }
        IGenericRepository<Status> StatusRepository { get; }
        Task Save();
    }
}
