using PracticaWinFormsTienda.Models;

namespace PracticaWinFormsTienda.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<CategoriaDto>> GetAllAsync();

        Task AddAsync(CategoriaDto categoria);

        Task UpdateAsync(CategoriaDto categoria);

        Task DeleteAsync(int id);
    }
}
