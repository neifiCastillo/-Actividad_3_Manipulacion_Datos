using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Utils;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmCategorias : Form
    {
        private readonly ICategoriaRepository _categoriaRepo;
        public FrmCategorias(ICategoriaRepository categoriaRepo)
        {
            InitializeComponent();
            _categoriaRepo = categoriaRepo;
        }
        private async void FrmCategorias_Load(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }
        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }
        private async Task CargarCategoriasAsync()
        {
            try
            {
                btnCargar.Enabled = false;

                var lista = await _categoriaRepo.GetAllAsync();
                dgvCategorias.DataSource = lista.ToList();
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

                var categoria = new Categoria
                {
                    NombreCategoria = txtInsertNombre.Text.Trim()
                };

                await _categoriaRepo.InsertAsync(categoria);

                UIHelper.MostrarInfo("Categoría insertada correctamente.");
                LimpiarInsert();
                await CargarCategoriasAsync();
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
                    "¿Seguro que desea eliminar esta categoría?");

                if (confirm == DialogResult.No)
                    return;

                await _categoriaRepo.DeleteAsync(id);

                UIHelper.MostrarInfo("Categoría eliminada correctamente.");
                txtEliminarId.Clear();
                await CargarCategoriasAsync();
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

                var categoria = new Categoria
                {
                    CategoriaID = int.Parse(txtActualizarId.Text),
                    NombreCategoria = txtActualizarNombre.Text.Trim()
                };

                await _categoriaRepo.UpdateAsync(categoria);

                UIHelper.MostrarInfo("Categoría actualizada correctamente.");
                LimpiarActualizar();
                await CargarCategoriasAsync();
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
                UIHelper.MostrarError("Todos los campos de Insertar son obligatorios.");
                return false;
            }
            return true;
        }
        private bool ValidarActualizar()
        {
            if (string.IsNullOrWhiteSpace(txtActualizarId.Text) ||
                string.IsNullOrWhiteSpace(txtActualizarNombre.Text))
            {
                UIHelper.MostrarError("Todos los campos de Actualizar son obligatorios.");
                return false;
            }

            if (!int.TryParse(txtActualizarId.Text, out _))
            {
                UIHelper.MostrarError("El ID debe ser numérico.");
                return false;
            }
            return true;
        }
        private void LimpiarInsert()
        {
            txtInsertNombre.Clear();
        }
        private void LimpiarActualizar()
        {
            txtActualizarId.Clear();
            txtActualizarNombre.Clear();
        }
        private void txtEliminarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }
        private void txtActualizarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }
    }
}

