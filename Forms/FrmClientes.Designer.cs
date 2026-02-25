namespace PracticaWinFormsTienda.Forms
{
    partial class FrmClientes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            groupBoxMostrar = new GroupBox();
            dgvClientes = new DataGridView();
            btnCargar = new Button();
            btnActualizar = new Button();
            lblIdActulizar = new Label();
            txtActualizarId = new TextBox();
            groupBoxEliminar = new GroupBox();
            btnEliminar = new Button();
            lblID = new Label();
            txtEliminarId = new TextBox();
            groupBoxInsertar = new GroupBox();
            lblDireccion = new Label();
            txtInsertDireccion = new TextBox();
            lblTelefono = new Label();
            txtInsertTelefono = new TextBox();
            lblCorreo = new Label();
            txtInsertCorreo = new TextBox();
            lblNombreClientes = new Label();
            btnAgregar = new Button();
            txtInsertNombre = new TextBox();
            groupBox1 = new GroupBox();
            lblDireccionActualizar = new Label();
            txtActualizarDireccion = new TextBox();
            lblTelefonoActualizar = new Label();
            txtActualizarTelefono = new TextBox();
            lblCorreoActualizar = new Label();
            txtActualizarCorreo = new TextBox();
            lblNombreActualizar = new Label();
            txtActualizarNombre = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBoxEliminar.SuspendLayout();
            groupBoxInsertar.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMostrar
            // 
            groupBoxMostrar.Controls.Add(dgvClientes);
            groupBoxMostrar.Controls.Add(btnCargar);
            groupBoxMostrar.Location = new Point(2, 302);
            groupBoxMostrar.Name = "groupBoxMostrar";
            groupBoxMostrar.Size = new Size(1098, 224);
            groupBoxMostrar.TabIndex = 7;
            groupBoxMostrar.TabStop = false;
            groupBoxMostrar.Text = "Mostrar";
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 61);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(1077, 150);
            dgvClientes.TabIndex = 3;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(6, 22);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(263, 33);
            btnCargar.TabIndex = 13;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(185, 232);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 33);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblIdActulizar
            // 
            lblIdActulizar.AutoSize = true;
            lblIdActulizar.Location = new Point(14, 26);
            lblIdActulizar.Name = "lblIdActulizar";
            lblIdActulizar.Size = new Size(18, 15);
            lblIdActulizar.TabIndex = 6;
            lblIdActulizar.Text = "ID";
            // 
            // txtActualizarId
            // 
            txtActualizarId.Location = new Point(14, 48);
            txtActualizarId.Name = "txtActualizarId";
            txtActualizarId.Size = new Size(95, 23);
            txtActualizarId.TabIndex = 7;
            txtActualizarId.KeyPress += txtActualizarId_KeyPress;
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Controls.Add(btnEliminar);
            groupBoxEliminar.Controls.Add(lblID);
            groupBoxEliminar.Controls.Add(txtEliminarId);
            groupBoxEliminar.Location = new Point(343, 12);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(240, 139);
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
            btnEliminar.TabIndex = 6;
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
            txtEliminarId.TabIndex = 5;
            txtEliminarId.KeyPress += txtEliminarId_KeyPress;
            // 
            // groupBoxInsertar
            // 
            groupBoxInsertar.Controls.Add(lblDireccion);
            groupBoxInsertar.Controls.Add(txtInsertDireccion);
            groupBoxInsertar.Controls.Add(lblTelefono);
            groupBoxInsertar.Controls.Add(txtInsertTelefono);
            groupBoxInsertar.Controls.Add(lblCorreo);
            groupBoxInsertar.Controls.Add(txtInsertCorreo);
            groupBoxInsertar.Controls.Add(lblNombreClientes);
            groupBoxInsertar.Controls.Add(btnAgregar);
            groupBoxInsertar.Controls.Add(txtInsertNombre);
            groupBoxInsertar.Location = new Point(2, 12);
            groupBoxInsertar.Name = "groupBoxInsertar";
            groupBoxInsertar.Size = new Size(335, 284);
            groupBoxInsertar.TabIndex = 4;
            groupBoxInsertar.TabStop = false;
            groupBoxInsertar.Text = "Insertar";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(8, 148);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Direccion";
            // 
            // txtInsertDireccion
            // 
            txtInsertDireccion.Location = new Point(6, 170);
            txtInsertDireccion.Name = "txtInsertDireccion";
            txtInsertDireccion.Size = new Size(322, 23);
            txtInsertDireccion.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(8, 93);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            // 
            // txtInsertTelefono
            // 
            txtInsertTelefono.Location = new Point(6, 115);
            txtInsertTelefono.Name = "txtInsertTelefono";
            txtInsertTelefono.Size = new Size(151, 23);
            txtInsertTelefono.TabIndex = 2;
            txtInsertTelefono.TextChanged += txtInsertTelefono_TextChanged;
            txtInsertTelefono.KeyPress += txtInsertTelefono_KeyPress;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(179, 34);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // txtInsertCorreo
            // 
            txtInsertCorreo.Location = new Point(177, 56);
            txtInsertCorreo.Name = "txtInsertCorreo";
            txtInsertCorreo.Size = new Size(151, 23);
            txtInsertCorreo.TabIndex = 1;
            txtInsertCorreo.TextChanged += txtInsertCorreo_TextChanged;
            // 
            // lblNombreClientes
            // 
            lblNombreClientes.AutoSize = true;
            lblNombreClientes.Location = new Point(8, 34);
            lblNombreClientes.Name = "lblNombreClientes";
            lblNombreClientes.Size = new Size(51, 15);
            lblNombreClientes.TabIndex = 3;
            lblNombreClientes.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(92, 232);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtInsertNombre
            // 
            txtInsertNombre.Location = new Point(6, 56);
            txtInsertNombre.Name = "txtInsertNombre";
            txtInsertNombre.Size = new Size(153, 23);
            txtInsertNombre.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(lblDireccionActualizar);
            groupBox1.Controls.Add(lblIdActulizar);
            groupBox1.Controls.Add(txtActualizarId);
            groupBox1.Controls.Add(txtActualizarDireccion);
            groupBox1.Controls.Add(lblTelefonoActualizar);
            groupBox1.Controls.Add(txtActualizarTelefono);
            groupBox1.Controls.Add(lblCorreoActualizar);
            groupBox1.Controls.Add(txtActualizarCorreo);
            groupBox1.Controls.Add(lblNombreActualizar);
            groupBox1.Controls.Add(txtActualizarNombre);
            groupBox1.Location = new Point(589, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 284);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // lblDireccionActualizar
            // 
            lblDireccionActualizar.AutoSize = true;
            lblDireccionActualizar.Location = new Point(185, 137);
            lblDireccionActualizar.Name = "lblDireccionActualizar";
            lblDireccionActualizar.Size = new Size(57, 15);
            lblDireccionActualizar.TabIndex = 9;
            lblDireccionActualizar.Text = "Direccion";
            // 
            // txtActualizarDireccion
            // 
            txtActualizarDireccion.Location = new Point(183, 159);
            txtActualizarDireccion.Name = "txtActualizarDireccion";
            txtActualizarDireccion.Size = new Size(322, 23);
            txtActualizarDireccion.TabIndex = 11;
            // 
            // lblTelefonoActualizar
            // 
            lblTelefonoActualizar.AutoSize = true;
            lblTelefonoActualizar.Location = new Point(14, 137);
            lblTelefonoActualizar.Name = "lblTelefonoActualizar";
            lblTelefonoActualizar.Size = new Size(53, 15);
            lblTelefonoActualizar.TabIndex = 7;
            lblTelefonoActualizar.Text = "Telefono";
            // 
            // txtActualizarTelefono
            // 
            txtActualizarTelefono.Location = new Point(12, 159);
            txtActualizarTelefono.Name = "txtActualizarTelefono";
            txtActualizarTelefono.Size = new Size(151, 23);
            txtActualizarTelefono.TabIndex = 10;
            txtActualizarTelefono.TextChanged += txtActualizarTelefono_TextChanged;
            txtActualizarTelefono.KeyPress += txtActualizarTelefono_KeyPress;
            // 
            // lblCorreoActualizar
            // 
            lblCorreoActualizar.AutoSize = true;
            lblCorreoActualizar.Location = new Point(185, 78);
            lblCorreoActualizar.Name = "lblCorreoActualizar";
            lblCorreoActualizar.Size = new Size(43, 15);
            lblCorreoActualizar.TabIndex = 5;
            lblCorreoActualizar.Text = "Correo";
            // 
            // txtActualizarCorreo
            // 
            txtActualizarCorreo.Location = new Point(183, 100);
            txtActualizarCorreo.Name = "txtActualizarCorreo";
            txtActualizarCorreo.Size = new Size(151, 23);
            txtActualizarCorreo.TabIndex = 9;
            txtActualizarCorreo.TextChanged += txtActualizarCorreo_TextChanged;
            // 
            // lblNombreActualizar
            // 
            lblNombreActualizar.AutoSize = true;
            lblNombreActualizar.Location = new Point(14, 78);
            lblNombreActualizar.Name = "lblNombreActualizar";
            lblNombreActualizar.Size = new Size(51, 15);
            lblNombreActualizar.TabIndex = 3;
            lblNombreActualizar.Text = "Nombre";
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(12, 100);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(153, 23);
            txtActualizarNombre.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 528);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxMostrar);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxInsertar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += FrmClientes_Load;
            groupBoxMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxInsertar.ResumeLayout(false);
            groupBoxInsertar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMostrar;
        private DataGridView dgvClientes;
        private Button btnCargar;
        private Button btnActualizar;
        private Label lblIdActulizar;
        private TextBox txtActualizarId;
        private GroupBox groupBoxEliminar;
        private Button btnEliminar;
        private Label lblID;
        private TextBox txtEliminarId;
        private GroupBox groupBoxInsertar;
        private Label lblNombreClientes;
        private Button btnAgregar;
        private TextBox txtInsertNombre;
        private Label lblDireccion;
        private TextBox txtInsertDireccion;
        private Label lblTelefono;
        private TextBox txtInsertTelefono;
        private Label lblCorreo;
        private TextBox txtInsertCorreo;
        private GroupBox groupBox1;
        private Label lblDireccionActualizar;
        private TextBox txtActualizarDireccion;
        private Label lblTelefonoActualizar;
        private TextBox txtActualizarTelefono;
        private Label lblCorreoActualizar;
        private TextBox txtActualizarCorreo;
        private Label lblNombreActualizar;
        private TextBox txtActualizarNombre;
        private ErrorProvider errorProvider1;
    }
}