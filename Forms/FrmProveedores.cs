using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmProveedores: Form
    {
        private readonly IProveedorRepository _proveedorRepo;
        public FrmProveedores(IProveedorRepository proveedorRepo)
        {
            InitializeComponent();
            _proveedorRepo = proveedorRepo;
        }
    }
}
