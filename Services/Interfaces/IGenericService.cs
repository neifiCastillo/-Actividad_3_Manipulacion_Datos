using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

