namespace PracticaWinFormsTienda.Forms
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            groupBoxMostrar = new GroupBox();
            dgvProductos = new DataGridView();
            btnCargar = new Button();
            groupBoxEliminar = new GroupBox();
            btnEliminar = new Button();
            lblID = new Label();
            txtEliminarId = new TextBox();
            groupBoxInsertar = new GroupBox();
            lblCategoria = new Label();
            cboInsertCategoria = new ComboBox();
            lblstock = new Label();
            txtInsertStock = new TextBox();
            lblDescripcion = new Label();
            txtInsertDescripcion = new TextBox();
            lblprecio = new Label();
            txtInsertPrecio = new TextBox();
            lblNombreProducto = new Label();
            btnAgregar = new Button();
            txtInsertNombre = new TextBox();
            groupBox1 = new GroupBox();
            lblIdActualiar = new Label();
            txtActualizarId = new TextBox();
            lblCategoriaActualizar = new Label();
            cboActualizarCategoria = new ComboBox();
            lblStockActualizar = new Label();
            txtActualizarStock = new TextBox();
            lblPrecioActualizar = new Label();
            txtActualizarPrecio = new TextBox();
            lblNombreActualizar = new Label();
            txtActualizarNombre = new TextBox();
            lblDescricionActualizar = new Label();
            btnActualizar = new Button();
            txtActualizarDescripcion = new TextBox();
            groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBoxEliminar.SuspendLayout();
            groupBoxInsertar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMostrar
            // 
            groupBoxMostrar.Controls.Add(dgvProductos);
            groupBoxMostrar.Controls.Add(btnCargar);
            groupBoxMostrar.Location = new Point(3, 285);
            groupBoxMostrar.Name = "groupBoxMostrar";
            groupBoxMostrar.Size = new Size(1217, 224);
            groupBoxMostrar.TabIndex = 7;
            groupBoxMostrar.TabStop = false;
            groupBoxMostrar.Text = "Mostrar";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 61);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(1205, 150);
            dgvProductos.TabIndex = 3;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(6, 22);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(263, 33);
            btnCargar.TabIndex = 16;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Controls.Add(btnEliminar);
            groupBoxEliminar.Controls.Add(lblID);
            groupBoxEliminar.Controls.Add(txtEliminarId);
            groupBoxEliminar.Location = new Point(488, 3);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(240, 276);
            groupBoxEliminar.TabIndex = 5;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(50, 99);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 33);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(8, 34);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 4;
            lblID.Text = "ID";
            // 
            // txtEliminarId
            // 
            txtEliminarId.Location = new Point(6, 56);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(228, 23);
            txtEliminarId.TabIndex = 7;
            txtEliminarId.KeyPress += txtEliminarId_KeyPress;
            // 
            // groupBoxInsertar
            // 
            groupBoxInsertar.Controls.Add(lblCategoria);
            groupBoxInsertar.Controls.Add(cboInsertCategoria);
            groupBoxInsertar.Controls.Add(lblstock);
            groupBoxInsertar.Controls.Add(txtInsertStock);
            groupBoxInsertar.Controls.Add(lblDescripcion);
            groupBoxInsertar.Controls.Add(txtInsertDescripcion);
            groupBoxInsertar.Controls.Add(lblprecio);
            groupBoxInsertar.Controls.Add(txtInsertPrecio);
            groupBoxInsertar.Controls.Add(lblNombreProducto);
            groupBoxInsertar.Controls.Add(btnAgregar);
            groupBoxInsertar.Controls.Add(txtInsertNombre);
            groupBoxInsertar.Location = new Point(3, 3);
            groupBoxInsertar.Name = "groupBoxInsertar";
            groupBoxInsertar.Size = new Size(479, 276);
            groupBoxInsertar.TabIndex = 4;
            groupBoxInsertar.TabStop = false;
            groupBoxInsertar.Text = "Insertar";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(262, 94);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoria";
            // 
            // cboInsertCategoria
            // 
            cboInsertCategoria.FormattingEnabled = true;
            cboInsertCategoria.Location = new Point(262, 116);
            cboInsertCategoria.Name = "cboInsertCategoria";
            cboInsertCategoria.Size = new Size(211, 23);
            cboInsertCategoria.TabIndex = 4;
            // 
            // lblstock
            // 
            lblstock.AutoSize = true;
            lblstock.Location = new Point(8, 153);
            lblstock.Name = "lblstock";
            lblstock.Size = new Size(36, 15);
            lblstock.TabIndex = 11;
            lblstock.Text = "Stock";
            // 
            // txtInsertStock
            // 
            txtInsertStock.Location = new Point(6, 175);
            txtInsertStock.Name = "txtInsertStock";
            txtInsertStock.Size = new Size(116, 23);
            txtInsertStock.TabIndex = 5;
            txtInsertStock.KeyPress += txtInsertStock_KeyPress;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(262, 34);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtInsertDescripcion
            // 
            txtInsertDescripcion.Location = new Point(262, 56);
            txtInsertDescripcion.Name = "txtInsertDescripcion";
            txtInsertDescripcion.Size = new Size(211, 23);
            txtInsertDescripcion.TabIndex = 1;
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(8, 94);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(40, 15);
            lblprecio.TabIndex = 5;
            lblprecio.Text = "Precio";
            // 
            // txtInsertPrecio
            // 
            txtInsertPrecio.Location = new Point(6, 116);
            txtInsertPrecio.Name = "txtInsertPrecio";
            txtInsertPrecio.Size = new Size(222, 23);
            txtInsertPrecio.TabIndex = 3;
            txtInsertPrecio.KeyPress += txtInsertPrecio_KeyPress;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(8, 34);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(51, 15);
            lblNombreProducto.TabIndex = 3;
            lblNombreProducto.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(148, 228);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 33);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtInsertNombre
            // 
            txtInsertNombre.Location = new Point(6, 56);
            txtInsertNombre.Name = "txtInsertNombre";
            txtInsertNombre.Size = new Size(222, 23);
            txtInsertNombre.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIdActualiar);
            groupBox1.Controls.Add(txtActualizarId);
            groupBox1.Controls.Add(lblCategoriaActualizar);
            groupBox1.Controls.Add(cboActualizarCategoria);
            groupBox1.Controls.Add(lblStockActualizar);
            groupBox1.Controls.Add(txtActualizarStock);
            groupBox1.Controls.Add(lblPrecioActualizar);
            groupBox1.Controls.Add(txtActualizarPrecio);
            groupBox1.Controls.Add(lblNombreActualizar);
            groupBox1.Controls.Add(txtActualizarNombre);
            groupBox1.Controls.Add(lblDescricionActualizar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtActualizarDescripcion);
            groupBox1.Location = new Point(734, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 276);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // lblIdActualiar
            // 
            lblIdActualiar.AutoSize = true;
            lblIdActualiar.Location = new Point(10, 25);
            lblIdActualiar.Name = "lblIdActualiar";
            lblIdActualiar.Size = new Size(18, 15);
            lblIdActualiar.TabIndex = 15;
            lblIdActualiar.Text = "ID";
            // 
            // txtActualizarId
            // 
            txtActualizarId.Location = new Point(8, 47);
            txtActualizarId.Name = "txtActualizarId";
            txtActualizarId.Size = new Size(116, 23);
            txtActualizarId.TabIndex = 9;
            txtActualizarId.KeyPress += txtActualizarId_KeyPress;
            // 
            // lblCategoriaActualizar
            // 
            lblCategoriaActualizar.AutoSize = true;
            lblCategoriaActualizar.Location = new Point(8, 146);
            lblCategoriaActualizar.Name = "lblCategoriaActualizar";
            lblCategoriaActualizar.Size = new Size(58, 15);
            lblCategoriaActualizar.TabIndex = 13;
            lblCategoriaActualizar.Text = "Categoria";
            // 
            // cboActualizarCategoria
            // 
            cboActualizarCategoria.FormattingEnabled = true;
            cboActualizarCategoria.Location = new Point(8, 168);
            cboActualizarCategoria.Name = "cboActualizarCategoria";
            cboActualizarCategoria.Size = new Size(220, 23);
            cboActualizarCategoria.TabIndex = 13;
            // 
            // lblStockActualizar
            // 
            lblStockActualizar.AutoSize = true;
            lblStockActualizar.Location = new Point(262, 150);
            lblStockActualizar.Name = "lblStockActualizar";
            lblStockActualizar.Size = new Size(36, 15);
            lblStockActualizar.TabIndex = 11;
            lblStockActualizar.Text = "Stock";
            // 
            // txtActualizarStock
            // 
            txtActualizarStock.Location = new Point(260, 168);
            txtActualizarStock.Name = "txtActualizarStock";
            txtActualizarStock.Size = new Size(121, 23);
            txtActualizarStock.TabIndex = 14;
            txtActualizarStock.KeyPress += txtActualizarStock_KeyPress;
            // 
            // lblPrecioActualizar
            // 
            lblPrecioActualizar.AutoSize = true;
            lblPrecioActualizar.Location = new Point(264, 84);
            lblPrecioActualizar.Name = "lblPrecioActualizar";
            lblPrecioActualizar.Size = new Size(40, 15);
            lblPrecioActualizar.TabIndex = 9;
            lblPrecioActualizar.Text = "Precio";
            // 
            // txtActualizarPrecio
            // 
            txtActualizarPrecio.Location = new Point(262, 106);
            txtActualizarPrecio.Name = "txtActualizarPrecio";
            txtActualizarPrecio.Size = new Size(211, 23);
            txtActualizarPrecio.TabIndex = 12;
            txtActualizarPrecio.KeyPress += txtActualizarPrecio_KeyPress;
            // 
            // lblNombreActualizar
            // 
            lblNombreActualizar.AutoSize = true;
            lblNombreActualizar.Location = new Point(264, 25);
            lblNombreActualizar.Name = "lblNombreActualizar";
            lblNombreActualizar.Size = new Size(51, 15);
            lblNombreActualizar.TabIndex = 7;
            lblNombreActualizar.Text = "Nombre";
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(264, 47);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(211, 23);
            txtActualizarNombre.TabIndex = 10;
            // 
            // lblDescricionActualizar
            // 
            lblDescricionActualizar.AutoSize = true;
            lblDescricionActualizar.Location = new Point(8, 84);
            lblDescricionActualizar.Name = "lblDescricionActualizar";
            lblDescricionActualizar.Size = new Size(69, 15);
            lblDescricionActualizar.TabIndex = 3;
            lblDescricionActualizar.Text = "Descripcion";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(175, 228);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 33);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtActualizarDescripcion
            // 
            txtActualizarDescripcion.Location = new Point(6, 106);
            txtActualizarDescripcion.Name = "txtActualizarDescripcion";
            txtActualizarDescripcion.Size = new Size(222, 23);
            txtActualizarDescripcion.TabIndex = 11;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 514);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxMostrar);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxInsertar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += FrmProductos_Load;
            groupBoxMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxInsertar.ResumeLayout(false);
            groupBoxInsertar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMostrar;
        private DataGridView dgvProductos;
        private Button btnCargar;
        private GroupBox groupBoxEliminar;
        private Button btnEliminar;
        private Label lblID;
        private TextBox txtEliminarId;
        private GroupBox groupBoxInsertar;
        private Label lblNombreProducto;
        private Button btnAgregar;
        private TextBox txtInsertNombre;
        private Label lblDescripcion;
        private TextBox txtInsertDescripcion;
        private Label lblprecio;
        private TextBox txtInsertPrecio;
        private Label lblCategoria;
        private ComboBox cboInsertCategoria;
        private Label lblstock;
        private TextBox txtInsertStock;
        private GroupBox groupBox1;
        private Label lblIdActualiar;
        private TextBox txtActualizarId;
        private Label lblCategoriaActualizar;
        private ComboBox cboActualizarCategoria;
        private Label lblStockActualizar;
        private TextBox txtActualizarStock;
        private Label lblPrecioActualizar;
        private TextBox txtActualizarPrecio;
        private Label lblNombreActualizar;
        private TextBox txtActualizarNombre;
        private Label lblDescricionActualizar;
        private Button btnActualizar;
        private TextBox txtActualizarDescripcion;
    }
}