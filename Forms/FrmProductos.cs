using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmProductos: Form
    {
        private readonly IProductoRepository _productoRepo;
        private readonly ICategoriaRepository _categoriaRepo;
        public FrmProductos(IProductoRepository productoRepo , ICategoriaRepository categoriaRepo)
        {
            InitializeComponent();
            _productoRepo = productoRepo;
            _categoriaRepo = categoriaRepo;
        }
    }
}
