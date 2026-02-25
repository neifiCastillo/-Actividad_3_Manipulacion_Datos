using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmProveedores : Form
    {
        private readonly IProveedorRepository _proveedorRepo;

        public FrmProveedores(IProveedorRepository proveedorRepo)
        {
            InitializeComponent();
            _proveedorRepo = proveedorRepo;
        }
        private async void FrmProveedores_Load(object sender, EventArgs e)
        {
            await CargarProveedoresAsync();
        }
        private async Task CargarProveedoresAsync()
        {
            try
            {
                btnCargar.Enabled = false;

                var proveedores = await _proveedorRepo.GetAllAsync();
                dgvProveedores.DataSource = proveedores.ToList();
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
            await CargarProveedoresAsync();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInsert())
                    return;

                var proveedor = new Proveedor
                {
                    NombreProveedor = txtInsertNombre.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtInsertTelefono.Text)
                        ? null
                        : txtInsertTelefono.Text.Trim(),
                    CorreoElectronico = string.IsNullOrWhiteSpace(txtInsertCorreo.Text)
                        ? null
                        : txtInsertCorreo.Text.Trim()
                };

                await _proveedorRepo.InsertAsync(proveedor);

                MostrarInfo("Proveedor insertado correctamente.");
                LimpiarInsert();
                await CargarProveedoresAsync();
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
                    "¿Seguro que desea eliminar este proveedor?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;

                await _proveedorRepo.DeleteAsync(id);

                MostrarInfo("Proveedor eliminado correctamente.");
                txtEliminarId.Clear();
                await CargarProveedoresAsync();
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

                var proveedor = new Proveedor
                {
                    ProveedorID = int.Parse(txtActualizarId.Text),
                    NombreProveedor = txtActualizarNombre.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtActualizarTelefono.Text)
                        ? null
                        : txtActualizarTelefono.Text.Trim(),
                    CorreoElectronico = string.IsNullOrWhiteSpace(txtActualizarCorreo.Text)
                        ? null
                        : txtActualizarCorreo.Text.Trim()
                };

                await _proveedorRepo.UpdateAsync(proveedor);

                MostrarInfo("Proveedor actualizado correctamente.");
                LimpiarActualizar();
                await CargarProveedoresAsync();
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
