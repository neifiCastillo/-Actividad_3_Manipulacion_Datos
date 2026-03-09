using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Forms;
using PracticaWinFormsTienda.Repositories;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Services;
using PracticaWinFormsTienda.Services.Interfaces;
using System.Configuration;

namespace PracticaWinFormsTienda
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            //DbContext
            var connectionString = ConfigurationManager
                 .ConnectionStrings["PracticaTiendaDB"]
                 .ConnectionString;

            services.AddDbContext<PracticaTiendaContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            // Repositories
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProveedorRepository, ProveedorRepository>();

            // UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Services
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IProveedorService, ProveedorService>();

            // forms
            services.AddTransient<FrmMain>();
            services.AddTransient<FrmCategorias>();
            services.AddTransient<FrmProductos>();
            services.AddTransient<FrmClientes>();
            services.AddTransient<FrmProveedores>();

            ServiceProvider = services.BuildServiceProvider();

            Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
        }
    }
}