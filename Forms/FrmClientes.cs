using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Forms
{

    public partial class FrmClientes : Form
    {
        private readonly IClienteRepository _clienteRepo;

        public FrmClientes(IClienteRepository clienteRepo)
        {
            InitializeComponent();
            _clienteRepo = clienteRepo;
        }
        private async void FrmClientes_Load(object sender, EventArgs e)
        {
            await CargarClientesAsync();
        }
        private async Task CargarClientesAsync()
        {
            try
            {
                btnCargar.Enabled = false;

                var clientes = await _clienteRepo.GetAllAsync();
                dgvClientes.DataSource = clientes.ToList();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            finally
            {
                btnCargar.Enabled = true;
            }
        }
        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await CargarClientesAsync();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInsert())
                    return;

                var cliente = new Cliente
                {
                    NombreCompleto = txtInsertNombre.Text.Trim(),
                    CorreoElectronico = string.IsNullOrWhiteSpace(txtInsertCorreo.Text)
                        ? null
                        : txtInsertCorreo.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtInsertTelefono.Text)
                        ? null
                        : txtInsertTelefono.Text.Trim(),
                    Direccion = string.IsNullOrWhiteSpace(txtInsertDireccion.Text)
                        ? null
                        : txtInsertDireccion.Text.Trim()
                };

                await _clienteRepo.InsertAsync(cliente);

                MostrarInfo("Cliente insertado correctamente.");
                LimpiarInsert();
                await CargarClientesAsync();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEliminarId.Text))
                {
                    MostrarError("Debe ingresar el ID a eliminar.");
                    return;
                }

                int id = int.Parse(txtEliminarId.Text);

                var confirm = MessageBox.Show(
                    "¿Seguro que desea eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;

                await _clienteRepo.DeleteAsync(id);

                MostrarInfo("Cliente eliminado correctamente.");
                txtEliminarId.Clear();
                await CargarClientesAsync();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarActualizar())
                    return;

                var cliente = new Cliente
                {
                    ClienteID = int.Parse(txtActualizarId.Text),
                    NombreCompleto = txtActualizarNombre.Text.Trim(),
                    CorreoElectronico = string.IsNullOrWhiteSpace(txtActualizarCorreo.Text)
                        ? null
                        : txtActualizarCorreo.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtActualizarTelefono.Text)
                        ? null
                        : txtActualizarTelefono.Text.Trim(),
                    Direccion = string.IsNullOrWhiteSpace(txtActualizarDireccion.Text)
                        ? null
                        : txtActualizarDireccion.Text.Trim()
                };

                await _clienteRepo.UpdateAsync(cliente);

                MostrarInfo("Cliente actualizado correctamente.");
                LimpiarActualizar();
                await CargarClientesAsync();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private bool ValidarInsert()
        {
            if (string.IsNullOrWhiteSpace(txtInsertNombre.Text))
            {
                MostrarError("Nombre son obligatorios.");
                return false;
            }

            return true;
        }
        private bool ValidarActualizar()
        {
            if (string.IsNullOrWhiteSpace(txtActualizarId.Text) ||
                string.IsNullOrWhiteSpace(txtActualizarNombre.Text))
            {
                MostrarError("ID y Nombre son obligatorios.");
                return false;
            }

            return true;
        }
        private void LimpiarInsert()
        {
            txtInsertNombre.Clear();
            txtInsertCorreo.Clear();
            txtInsertTelefono.Clear();
            txtInsertDireccion.Clear();
        }

        private void LimpiarActualizar()
        {
            txtActualizarId.Clear();
            txtActualizarNombre.Clear();
            txtActualizarCorreo.Clear();
            txtActualizarTelefono.Clear();
            txtActualizarDireccion.Clear();
        }
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void MostrarInfo(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

}
