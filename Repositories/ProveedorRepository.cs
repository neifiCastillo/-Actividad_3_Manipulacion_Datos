using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Repositories
{
    public class ProveedorRepository
        : GenericRepository<Proveedore>, IProveedorRepository
    {
        public ProveedorRepository(PracticaTiendaContext context)
            : base(context)
        {
        }
    }
}