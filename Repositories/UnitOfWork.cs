using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PracticaTiendaContext _context;

        public ICategoriaRepository Categorias { get; }

        public IProductoRepository Productos { get; }

        public IClienteRepository Clientes { get; }

        public IProveedorRepository Proveedores { get; }

        public UnitOfWork(
            PracticaTiendaContext context,
            ICategoriaRepository categoriaRepository,
            IProductoRepository productoRepository,
            IClienteRepository clienteRepository,
            IProveedorRepository proveedorRepository)
        {
            _context = context;

            Categorias = categoriaRepository;
            Productos = productoRepository;
            Clientes = clienteRepository;
            Proveedores = proveedorRepository;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}