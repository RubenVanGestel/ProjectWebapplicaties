using ProjectWebapplicaties.Data.Repositories.Interfaces;
using ProjectWebapplicaties.Data.Repositories.Repos;
using ProjectWebapplicaties.Models;
using System.Threading.Tasks;

namespace ProjectWebapplicaties.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectWebapplicatiesContext _context;
        private IGenericRepository<Bestelling> bestellingRepository;
        private IGenericRepository<BestellingPizza> bestellingPizzaRepository;
        private IGenericRepository<Klant> klantRepository;
        private IGenericRepository<Medewerker> medewerkerRepository;
        private IGenericRepository<Pizza> pizzaRepository;
        private IGenericRepository<PizzaGrootte> pizzaGrootteRepository;
        private IGenericRepository<Status> statusRepository;

        public UnitOfWork(ProjectWebapplicatiesContext context)
        {
            _context = context;
        }

        public IGenericRepository<Bestelling> BestellingRepository 
        { 
            get
            {
                if (this.bestellingRepository == null)
                {
                    this.bestellingRepository = new GenericRepository<Bestelling>(_context);
                }
                return bestellingRepository;
            }
        }

        public IGenericRepository<BestellingPizza> BestellingPizzaRepository
        {
            get
            {
                if (this.bestellingPizzaRepository == null)
                {
                    this.bestellingPizzaRepository = new GenericRepository<BestellingPizza>(_context);
                }
                return bestellingPizzaRepository;
            }
        }

        public IGenericRepository<Klant> KlantRepository
        {
            get
            {
                if (this.klantRepository == null)
                {
                    this.klantRepository = new GenericRepository<Klant>(_context);
                }
                return klantRepository;
            }
        }

        public IGenericRepository<Medewerker> MedewerkerRepository
        {
            get
            {
                if (this.medewerkerRepository == null)
                {
                    this.medewerkerRepository = new GenericRepository<Medewerker>(_context);
                }
                return medewerkerRepository;
            }
        }

        public IGenericRepository<Pizza> PizzaRepository
        {
            get
            {
                if (this.pizzaRepository == null)
                {
                    this.pizzaRepository = new GenericRepository<Pizza>(_context);
                }
                return pizzaRepository;
            }
        }

        public IGenericRepository<PizzaGrootte> PizzaGrootteRepository
        {
            get
            {
                if (this.pizzaGrootteRepository == null)
                {
                    this.pizzaGrootteRepository = new GenericRepository<PizzaGrootte>(_context);
                }
                return pizzaGrootteRepository;
            }
        }

        public IGenericRepository<Status> StatusRepository
        {
            get
            {
                if (this.statusRepository == null)
                {
                    this.statusRepository = new GenericRepository<Status>(_context);
                }
                return statusRepository;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
