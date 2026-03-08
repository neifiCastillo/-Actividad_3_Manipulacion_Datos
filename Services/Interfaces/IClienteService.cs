using PracticaWinFormsTienda.Models;

namespace PracticaWinFormsTienda.Services.Interfaces
{
    public interface IClienteService
    {
        Task<List<ClienteDto>> GetAllAsync();

        Task AddAsync(ClienteDto cliente);

        Task UpdateAsync(ClienteDto cliente);

        Task DeleteAsync(int id);
    }
}
