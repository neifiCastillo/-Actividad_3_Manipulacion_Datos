using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Utils;

namespace PracticaWinFormsTienda.Services
{
    public class ProveedorService
        : GenericService<ProveedorDto,Proveedore>, IProveedorService
    {
        public ProveedorService(
            IProveedorRepository repository,
            IUnitOfWork unitOfWork)
            : base(
                repository,
                unitOfWork,
                MapperHelper.ToDTO,
                MapperHelper.ToEntity)
        {
        }
    }
}