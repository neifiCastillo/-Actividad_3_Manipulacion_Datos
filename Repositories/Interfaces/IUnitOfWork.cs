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
