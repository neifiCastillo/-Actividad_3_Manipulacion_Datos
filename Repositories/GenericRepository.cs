using Microsoft.EntityFrameworkCore;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly PracticaTiendaContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(PracticaTiendaContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public Task UpdateAsync(TEntity entity)
        {
            _context.ChangeTracker.Clear();

            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            return Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}