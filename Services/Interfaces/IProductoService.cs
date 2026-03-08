using PracticaWinFormsTienda.Models;

namespace PracticaWinFormsTienda.Services.Interfaces
{
    public interface IProductoService
    {
        Task<List<ProductoDto>> GetAllWithCategoriaAsync();

        Task AddAsync(ProductoDto producto);

        Task UpdateAsync(ProductoDto producto);

        Task DeleteAsync(int id);
    }
}
