using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaWinFormsTienda.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriaRepository Categorias { get; }

        IProductoRepository Productos { get; }

        IClienteRepository Clientes { get; }

        IProveedorRepository Proveedores { get; }

        Task<int> SaveAsync();
    }
}
