using Microsoft.EntityFrameworkCore;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Repositories
{
    public class ProductoRepository
        : GenericRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(PracticaTiendaContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Producto>> GetAllWithCategoriaAsync()
        {
            return await _context.Productos
                .Include(p => p.Categoria)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}