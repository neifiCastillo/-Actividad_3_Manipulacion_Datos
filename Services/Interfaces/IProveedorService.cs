using PracticaWinFormsTienda.Models;

namespace PracticaWinFormsTienda.Services.Interfaces
{
    public interface IProveedorService
    {
        Task<List<ProveedorDto>> GetAllAsync();

        Task AddAsync(ProveedorDto proveedor);

        Task UpdateAsync(ProveedorDto proveedor);

        Task DeleteAsync(int id);
    }
}
