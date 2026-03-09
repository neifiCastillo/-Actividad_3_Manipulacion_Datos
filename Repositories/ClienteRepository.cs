using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Repositories
{
    public class ClienteRepository
        : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(PracticaTiendaContext context)
            : base(context)
        {
        }
    }
}