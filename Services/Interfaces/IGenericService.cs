namespace PracticaWinFormsTienda.Services.Interfaces
{
    public interface IGenericService<TDto>
    {
        Task<List<TDto>> GetAllAsync();

        Task AddAsync(TDto dto);

        Task UpdateAsync(TDto dto);

        Task DeleteAsync(int id);
    }
}

