using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Repositories;

namespace PracticaWinFormsTienda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Inyección
            ICategoriaRepository categoriaRepo = new CategoriaRepository();
            IProductoRepository productoRepo = new ProductoRepository();
            IClienteRepository clienteRepo = new ClienteRepository();
            IProveedorRepository proveedorRepo = new ProveedorRepository();
            Application.Run(new FrmMain(
                 categoriaRepo,
                 productoRepo,
                 clienteRepo,
                 proveedorRepo));
        }
    }
}