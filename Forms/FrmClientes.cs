using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Utils;

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
                UIHelper.MostrarError(ex.Message);
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
                        : UIHelper.LimpiarTelefono(txtInsertTelefono.Text),
                    Direccion = string.IsNullOrWhiteSpace(txtInsertDireccion.Text)
                        ? null
                        : txtInsertDireccion.Text.Trim()
                };

                await _clienteRepo.InsertAsync(cliente);

                UIHelper.MostrarInfo("Cliente insertado correctamente.");
                LimpiarInsert();
                await CargarClientesAsync();
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError(ex.Message);
            }
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEliminarId.Text))
                {
                    UIHelper.MostrarError("Debe ingresar el ID a eliminar.");
                    return;
                }

                int id = int.Parse(txtEliminarId.Text);

                var confirm = UIHelper.Confirmar(
                    "¿Seguro que desea eliminar este cliente?");

                if (confirm == DialogResult.No)
                    return;

                await _clienteRepo.DeleteAsync(id);

                UIHelper.MostrarInfo("Cliente eliminado correctamente.");
                txtEliminarId.Clear();
                await CargarClientesAsync();
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError(ex.Message);
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
                        : UIHelper.LimpiarTelefono(txtActualizarTelefono.Text),
                    Direccion = string.IsNullOrWhiteSpace(txtActualizarDireccion.Text)
                        ? null
                        : txtActualizarDireccion.Text.Trim()
                };

                await _clienteRepo.UpdateAsync(cliente);

                UIHelper.MostrarInfo("Cliente actualizado correctamente.");
                LimpiarActualizar();
                await CargarClientesAsync();
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError(ex.Message);
            }
        }
        private bool ValidarInsert()
        {
            if (string.IsNullOrWhiteSpace(txtInsertNombre.Text))
            {
                UIHelper.MostrarError("Nombre son obligatorios.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtInsertTelefono.Text) &&
                !UIHelper.EsTelefonoValidoRD(txtInsertTelefono.Text))
            {
                UIHelper.MostrarError("El teléfono debe tener 10 dígitos.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtInsertCorreo.Text) &&
                !UIHelper.EsCorreoValido(txtInsertCorreo.Text))
            {
                UIHelper.MostrarError("El correo electrónico no es válido.");
                return false;
            }

            return true;
        }
        private bool ValidarActualizar()
        {
            if (string.IsNullOrWhiteSpace(txtActualizarId.Text) ||
                string.IsNullOrWhiteSpace(txtActualizarNombre.Text))
            {
                UIHelper.MostrarError("ID y Nombre son obligatorios.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtActualizarTelefono.Text) &&
               !UIHelper.EsTelefonoValidoRD(txtActualizarTelefono.Text))
            {
                UIHelper.MostrarError("El teléfono debe tener 10 dígitos.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtActualizarCorreo.Text) &&
                !UIHelper.EsCorreoValido(txtActualizarCorreo.Text))
            {
                UIHelper.MostrarError("El correo electrónico no es válido.");
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
        private void txtEliminarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }
        private void txtActualizarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }
        private void txtInsertTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }
        private void txtActualizarTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }
        private void txtInsertTelefono_TextChanged(object sender, EventArgs e)
        {
            UIHelper.TelefonoRD_TextChanged(txtInsertTelefono);
        }
        private void txtActualizarTelefono_TextChanged(object sender, EventArgs e)
        {
            UIHelper.TelefonoRD_TextChanged(txtActualizarTelefono);
        }

        private void txtInsertCorreo_TextChanged(object sender, EventArgs e)
        {
            UIHelper.ValidarCorreoEnTiempoReal(txtInsertCorreo, errorProvider1);
        }

        private void txtActualizarCorreo_TextChanged(object sender, EventArgs e)
        {
            UIHelper.ValidarCorreoEnTiempoReal(txtActualizarCorreo, errorProvider1);
        }
    }

}
