using ProjectWebapplicaties.Data.Repositories.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebapplicaties.Data.Repositories.Repos
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ProjectWebapplicatiesContext _context;

        public GenericRepository(ProjectWebapplicatiesContext context)
        {
            _context = context;
        }


        public void Create(TEntity entity)
        {
           _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
           _context.Set<TEntity>().Update(entity);
        }
    }
}
