using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Forms
{
   
    public partial class FrmClientes: Form
    {
        private readonly IClienteRepository _clienteRepo;
        public FrmClientes(IClienteRepository clienteRepo)
        {
            InitializeComponent();
            _clienteRepo = clienteRepo;
        }
    }
    
}
