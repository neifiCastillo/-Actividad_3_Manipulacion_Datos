using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Utils;

namespace PracticaWinFormsTienda.Services
{
    public class ClienteService
        : GenericService<ClienteDto, Cliente>, IClienteService
    {
        public ClienteService(
            IClienteRepository repository,
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