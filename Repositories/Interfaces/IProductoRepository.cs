

using PracticaWinFormsTienda.Data;

namespace PracticaWinFormsTienda.Repositories.Interfaces
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<IEnumerable<Producto>> GetAllWithCategoriaAsync();
    }
}
