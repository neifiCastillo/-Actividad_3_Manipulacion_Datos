using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmProductos : Form
    {
        private readonly IProductoRepository _productoRepo;
        private readonly ICategoriaRepository _categoriaRepo;

        public FrmProductos(
            IProductoRepository productoRepo,
            ICategoriaRepository categoriaRepo)
        {
            InitializeComponent();
            _productoRepo = productoRepo;
            _categoriaRepo = categoriaRepo;
        }

        private async void FrmProductos_Load(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
            await CargarProductosAsync();
        }

        private async Task CargarCategoriasAsync()
        {
            try
            {
                var categorias = (await _categoriaRepo.GetAllAsync()).ToList();

                cboInsertCategoria.DataSource = categorias.ToList();
                cboInsertCategoria.DisplayMember = "NombreCategoria";
                cboInsertCategoria.ValueMember = "CategoriaID";

                cboActualizarCategoria.DataSource = categorias.ToList();
                cboActualizarCategoria.DisplayMember = "NombreCategoria";
                cboActualizarCategoria.ValueMember = "CategoriaID";
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private async Task CargarProductosAsync()
        {
            try
            {
                btnCargar.Enabled = false;

                var productos = await _productoRepo.GetAllAsync();

                var listaMostrar = productos.Select(p => new
                {
                    p.ProductoID,
                    p.NombreProducto,
                    p.Descripcion,
                    p.Precio,
                    p.Stock,
                    Categoria = p.Categoria != null
                                ? p.Categoria.NombreCategoria
                                : "Sin categoría"
                }).ToList();

                dgvProductos.DataSource = listaMostrar;

                dgvProductos.Columns["ProductoID"].HeaderText = "ID";
                dgvProductos.Columns["NombreProducto"].HeaderText = "Nombre";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Stock"].HeaderText = "Stock";
                dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
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
            await CargarProductosAsync();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInsert())
                    return;

                var producto = new Producto
                {
                    NombreProducto = txtInsertNombre.Text.Trim(),
                    Descripcion = txtInsertDescripcion.Text.Trim(),
                    Precio = decimal.Parse(txtInsertPrecio.Text),
                    Stock = int.Parse(txtInsertStock.Text),
                    CategoriaID = (int?)cboInsertCategoria.SelectedValue
                };

                await _productoRepo.InsertAsync(producto);

                MostrarInfo("Producto insertado correctamente.");
                LimpiarInsert();
                await CargarProductosAsync();
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
                    "¿Seguro que desea eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;

                await _productoRepo.DeleteAsync(id);

                MostrarInfo("Producto eliminado correctamente.");
                txtEliminarId.Clear();
                await CargarProductosAsync();
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

                var producto = new Producto
                {
                    ProductoID = int.Parse(txtActualizarId.Text),
                    NombreProducto = txtActualizarNombre.Text.Trim(),
                    Descripcion = txtActualizarDescripcion.Text.Trim(),
                    Precio = decimal.Parse(txtActualizarPrecio.Text),
                    Stock = int.Parse(txtActualizarStock.Text),
                    CategoriaID = (int?)cboActualizarCategoria.SelectedValue
                };

                await _productoRepo.UpdateAsync(producto);

                MostrarInfo("Producto actualizado correctamente.");
                LimpiarActualizar();
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private bool ValidarInsert()
        {
            if (string.IsNullOrWhiteSpace(txtInsertNombre.Text) ||
                string.IsNullOrWhiteSpace(txtInsertPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtInsertStock.Text))
            {
                MostrarError("Todos los campos obligatorios deben completarse.");
                return false;
            }

            if (!decimal.TryParse(txtInsertPrecio.Text, out _) ||
                !int.TryParse(txtInsertStock.Text, out _))
            {
                MostrarError("Precio y Stock deben ser numéricos.");
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
            txtInsertDescripcion.Clear();
            txtInsertPrecio.Clear();
            txtInsertStock.Clear();
        }
        private void LimpiarActualizar()
        {
            txtActualizarId.Clear();
            txtActualizarNombre.Clear();
            txtActualizarDescripcion.Clear();
            txtActualizarPrecio.Clear();
            txtActualizarStock.Clear();
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

        private void Int_KeyPress(KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y tampoco es la tecla de borrar (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }

        private void txtInsertPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int_KeyPress(e);
        }

        private void txtInsertStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int_KeyPress(e);
        }

        private void txtActualizarStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int_KeyPress(e);
        }

        private void txtActualizarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int_KeyPress(e);
        }
    }
}
