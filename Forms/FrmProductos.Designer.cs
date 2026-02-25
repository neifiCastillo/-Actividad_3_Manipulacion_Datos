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
            label7 = new Label();
            cboInsertCategoria = new ComboBox();
            label6 = new Label();
            txtInsertStock = new TextBox();
            label4 = new Label();
            txtInsertDescripcion = new TextBox();
            label3 = new Label();
            txtInsertPrecio = new TextBox();
            lblNombreProducto = new Label();
            btnAgregar = new Button();
            txtInsertNombre = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            txtActualizarId = new TextBox();
            label1 = new Label();
            cboActualizarCategoria = new ComboBox();
            label2 = new Label();
            txtActualizarStock = new TextBox();
            label8 = new Label();
            txtActualizarPrecio = new TextBox();
            label9 = new Label();
            txtActualizarNombre = new TextBox();
            label11 = new Label();
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
            btnCargar.TabIndex = 2;
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
            btnEliminar.TabIndex = 3;
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
            txtEliminarId.TabIndex = 1;
            // 
            // groupBoxInsertar
            // 
            groupBoxInsertar.Controls.Add(label7);
            groupBoxInsertar.Controls.Add(cboInsertCategoria);
            groupBoxInsertar.Controls.Add(label6);
            groupBoxInsertar.Controls.Add(txtInsertStock);
            groupBoxInsertar.Controls.Add(label4);
            groupBoxInsertar.Controls.Add(txtInsertDescripcion);
            groupBoxInsertar.Controls.Add(label3);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 94);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Categoria";
            // 
            // cboInsertCategoria
            // 
            cboInsertCategoria.FormattingEnabled = true;
            cboInsertCategoria.Location = new Point(262, 116);
            cboInsertCategoria.Name = "cboInsertCategoria";
            cboInsertCategoria.Size = new Size(211, 23);
            cboInsertCategoria.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 153);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Stock";
            // 
            // txtInsertStock
            // 
            txtInsertStock.Location = new Point(6, 175);
            txtInsertStock.Name = "txtInsertStock";
            txtInsertStock.Size = new Size(116, 23);
            txtInsertStock.TabIndex = 10;
            txtInsertStock.KeyPress += txtInsertStock_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 34);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // txtInsertDescripcion
            // 
            txtInsertDescripcion.Location = new Point(262, 56);
            txtInsertDescripcion.Name = "txtInsertDescripcion";
            txtInsertDescripcion.Size = new Size(211, 23);
            txtInsertDescripcion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // txtInsertPrecio
            // 
            txtInsertPrecio.Location = new Point(6, 116);
            txtInsertPrecio.Name = "txtInsertPrecio";
            txtInsertPrecio.Size = new Size(222, 23);
            txtInsertPrecio.TabIndex = 4;
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
            btnAgregar.TabIndex = 2;
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
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtActualizarId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboActualizarCategoria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtActualizarStock);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtActualizarPrecio);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtActualizarNombre);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtActualizarDescripcion);
            groupBox1.Location = new Point(734, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 276);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 25);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 15;
            label12.Text = "ID";
            // 
            // txtActualizarId
            // 
            txtActualizarId.Location = new Point(8, 47);
            txtActualizarId.Name = "txtActualizarId";
            txtActualizarId.Size = new Size(116, 23);
            txtActualizarId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 146);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 13;
            label1.Text = "Categoria";
            // 
            // cboActualizarCategoria
            // 
            cboActualizarCategoria.FormattingEnabled = true;
            cboActualizarCategoria.Location = new Point(8, 168);
            cboActualizarCategoria.Name = "cboActualizarCategoria";
            cboActualizarCategoria.Size = new Size(220, 23);
            cboActualizarCategoria.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 150);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Stock";
            // 
            // txtActualizarStock
            // 
            txtActualizarStock.Location = new Point(260, 168);
            txtActualizarStock.Name = "txtActualizarStock";
            txtActualizarStock.Size = new Size(121, 23);
            txtActualizarStock.TabIndex = 10;
            txtActualizarStock.KeyPress += txtActualizarStock_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 84);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 9;
            label8.Text = "Precio";
            // 
            // txtActualizarPrecio
            // 
            txtActualizarPrecio.Location = new Point(262, 106);
            txtActualizarPrecio.Name = "txtActualizarPrecio";
            txtActualizarPrecio.Size = new Size(211, 23);
            txtActualizarPrecio.TabIndex = 8;
            txtActualizarPrecio.KeyPress += txtActualizarPrecio_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(264, 25);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 7;
            label9.Text = "Nombre";
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(264, 47);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(211, 23);
            txtActualizarNombre.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 84);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 3;
            label11.Text = "Descripcion";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(175, 228);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 33);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtActualizarDescripcion
            // 
            txtActualizarDescripcion.Location = new Point(6, 106);
            txtActualizarDescripcion.Name = "txtActualizarDescripcion";
            txtActualizarDescripcion.Size = new Size(222, 23);
            txtActualizarDescripcion.TabIndex = 0;
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
        private Label label4;
        private TextBox txtInsertDescripcion;
        private Label label3;
        private TextBox txtInsertPrecio;
        private Label label7;
        private ComboBox cboInsertCategoria;
        private Label label6;
        private TextBox txtInsertStock;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox txtActualizarId;
        private Label label1;
        private ComboBox cboActualizarCategoria;
        private Label label2;
        private TextBox txtActualizarStock;
        private Label label8;
        private TextBox txtActualizarPrecio;
        private Label label9;
        private TextBox txtActualizarNombre;
        private Label label11;
        private Button btnActualizar;
        private TextBox txtActualizarDescripcion;
    }
}