using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Utils;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmProveedores : Form
    {
        private readonly IProveedorService _proveedorService;

        public FrmProveedores(IProveedorService proveedorService)
        {
            InitializeComponent();
            _proveedorService = proveedorService;
        }

        private async void FrmProveedores_Load(object sender, EventArgs e)
        {
            await CargarProveedoresAsync();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await CargarProveedoresAsync();
        }

        private async Task CargarProveedoresAsync()
        {
            try
            {
                btnCargar.Enabled = false;

                var proveedores = await _proveedorService.GetAllAsync();

                dgvProveedores.DataSource = proveedores.OrderByDescending(p => p.Id)
               .ToList(); ;

                dgvProveedores.Columns["Id"].HeaderText = "ID";
                dgvProveedores.Columns["NombreProveedor"].HeaderText = "Nombre";
                dgvProveedores.Columns["Telefono"].HeaderText = "Teléfono";
                dgvProveedores.Columns["CorreoElectronico"].HeaderText = "Correo";

                dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProveedores.ReadOnly = true;
                dgvProveedores.AllowUserToAddRows = false;
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInsert())
                    return;

                var proveedor = new ProveedorDto
                {
                    NombreProveedor = txtInsertNombre.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtInsertTelefono.Text)
                        ? null
                        : UIHelper.LimpiarTelefono(txtInsertTelefono.Text),
                    CorreoElectronico = string.IsNullOrWhiteSpace(txtInsertCorreo.Text)
                        ? null
                        : txtInsertCorreo.Text.Trim()
                };

                await _proveedorService.AddAsync(proveedor);

                UIHelper.MostrarInfo("Proveedor insertado correctamente.");

                LimpiarInsert();

                await CargarProveedoresAsync();
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
                    "¿Seguro que desea eliminar este proveedor?");

                if (confirm == DialogResult.No)
                    return;

                await _proveedorService.DeleteAsync(id);

                UIHelper.MostrarInfo("Proveedor eliminado correctamente.");

                txtEliminarId.Clear();

                await CargarProveedoresAsync();
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

                var proveedor = new ProveedorDto
                {
                    Id = int.Parse(txtActualizarId.Text),
                    NombreProveedor = txtActualizarNombre.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtActualizarTelefono.Text)
                        ? null
                        : UIHelper.LimpiarTelefono(txtActualizarTelefono.Text),
                    CorreoElectronico = string.IsNullOrWhiteSpace(txtActualizarCorreo.Text)
                        ? null
                        : txtActualizarCorreo.Text.Trim()
                };

                await _proveedorService.UpdateAsync(proveedor);

                UIHelper.MostrarInfo("Proveedor actualizado correctamente.");

                LimpiarActualizar();

                await CargarProveedoresAsync();
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
                UIHelper.MostrarError("El nombre es obligatorio.");
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
            txtInsertTelefono.Clear();
            txtInsertCorreo.Clear();
        }

        private void LimpiarActualizar()
        {
            txtActualizarId.Clear();
            txtActualizarNombre.Clear();
            txtActualizarTelefono.Clear();
            txtActualizarCorreo.Clear();
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