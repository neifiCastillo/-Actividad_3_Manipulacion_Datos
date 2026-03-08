using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Utils;

namespace PracticaWinFormsTienda.Forms
{
    public partial class FrmProductos : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;

        public FrmProductos(
            IProductoService productoService,
            ICategoriaService categoriaService)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
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
                var categorias = await _categoriaService.GetAllAsync();

                cboInsertCategoria.DataSource = categorias.ToList();
                cboInsertCategoria.DisplayMember = "Nombre";
                cboInsertCategoria.ValueMember = "Id";

                cboActualizarCategoria.DataSource = categorias.ToList();
                cboActualizarCategoria.DisplayMember = "Nombre";
                cboActualizarCategoria.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError(ex.Message);
            }
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                btnCargar.Enabled = false;

                var productos = await _productoService.GetAllWithCategoriaAsync();

                dgvProductos.DataSource = productos.OrderByDescending(p => p.Id)
               .ToList(); ;

                dgvProductos.Columns["Id"].HeaderText = "ID";
                dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Stock"].HeaderText = "Stock";
                dgvProductos.Columns["CategoriaNombre"].HeaderText = "Categoría";

                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProductos.ReadOnly = true;
                dgvProductos.AllowUserToAddRows = false;
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
            await CargarProductosAsync();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInsert())
                    return;

                var producto = new ProductoDto
                {
                    Nombre = txtInsertNombre.Text.Trim(),
                    Descripcion = txtInsertDescripcion.Text.Trim(),
                    Precio = decimal.Parse(txtInsertPrecio.Text),
                    Stock = int.Parse(txtInsertStock.Text),
                    CategoriaId = (int?)cboInsertCategoria.SelectedValue
                };

                await _productoService.AddAsync(producto);

                UIHelper.MostrarInfo("Producto insertado correctamente.");

                LimpiarInsert();

                await CargarProductosAsync();
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
                    "¿Seguro que desea eliminar este producto?");

                if (confirm == DialogResult.No)
                    return;

                await _productoService.DeleteAsync(id);

                UIHelper.MostrarInfo("Producto eliminado correctamente.");

                txtEliminarId.Clear();

                await CargarProductosAsync();
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

                var producto = new ProductoDto
                {
                    Id = int.Parse(txtActualizarId.Text),
                    Nombre = txtActualizarNombre.Text.Trim(),
                    Descripcion = txtActualizarDescripcion.Text.Trim(),
                    Precio = decimal.Parse(txtActualizarPrecio.Text),
                    Stock = int.Parse(txtActualizarStock.Text),
                    CategoriaId = (int?)cboActualizarCategoria.SelectedValue
                };

                await _productoService.UpdateAsync(producto);

                UIHelper.MostrarInfo("Producto actualizado correctamente.");

                LimpiarActualizar();

                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                UIHelper.MostrarError(ex.Message);
            }
        }

        private bool ValidarInsert()
        {
            if (string.IsNullOrWhiteSpace(txtInsertNombre.Text) ||
                string.IsNullOrWhiteSpace(txtInsertPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtInsertStock.Text))
            {
                UIHelper.MostrarError("Todos los campos obligatorios deben completarse.");
                return false;
            }

            if (!decimal.TryParse(txtInsertPrecio.Text, out _) ||
                !int.TryParse(txtInsertStock.Text, out _))
            {
                UIHelper.MostrarError("Precio y Stock deben ser numéricos.");
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

        private void txtInsertPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }

        private void txtInsertStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }

        private void txtActualizarStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
        }

        private void txtActualizarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIHelper.SoloNumeros(e);
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