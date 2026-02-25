using PracticaWinFormsTienda.Forms;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda
{
    public partial class FrmMain : Form
    {
        private readonly ICategoriaRepository _categoriaRepo;
        private readonly IProductoRepository _productoRepo;
        private readonly IClienteRepository _clienteRepo;
        private readonly IProveedorRepository _proveedorRepo;

        public FrmMain(
        ICategoriaRepository categoriaRepo,
        IProductoRepository productoRepo,
        IClienteRepository clienteRepo,
        IProveedorRepository proveedorRepo)
        {
            InitializeComponent();

            _categoriaRepo = categoriaRepo;
            _productoRepo = productoRepo;
            _clienteRepo = clienteRepo;
            _proveedorRepo = proveedorRepo;
        }


        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategorias(_categoriaRepo);
            frm.MdiParent = this;
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmProductos(_productoRepo, _categoriaRepo);
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmClientes(_clienteRepo);
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmProveedores(_proveedorRepo);
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
