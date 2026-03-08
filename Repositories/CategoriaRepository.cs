using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Repositories
{
    public class CategoriaRepository
        : GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(PracticaTiendaContext context)
            : base(context)
        {
        }
    }
}