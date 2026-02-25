namespace PracticaWinFormsTienda.Forms
{
    partial class FrmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            groupBox1 = new GroupBox();
            btnActualizar = new Button();
            lblIdActualizar = new Label();
            txtActualizarId = new TextBox();
            lblTelefonoActualizar = new Label();
            txtActualizarTelefono = new TextBox();
            lblCorreoActualizar = new Label();
            txtActualizarCorreo = new TextBox();
            lblNombreActualizar = new Label();
            txtActualizarNombre = new TextBox();
            groupBoxMostrar = new GroupBox();
            dgvProveedores = new DataGridView();
            btnCargar = new Button();
            groupBoxEliminar = new GroupBox();
            btnEliminar = new Button();
            lblID = new Label();
            txtEliminarId = new TextBox();
            groupBoxInsertar = new GroupBox();
            lblTelefono = new Label();
            txtInsertTelefono = new TextBox();
            lblCorreo = new Label();
            txtInsertCorreo = new TextBox();
            lblNombreProveedores = new Label();
            btnAgregar = new Button();
            txtInsertNombre = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            groupBoxEliminar.SuspendLayout();
            groupBoxInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(lblIdActualizar);
            groupBox1.Controls.Add(txtActualizarId);
            groupBox1.Controls.Add(lblTelefonoActualizar);
            groupBox1.Controls.Add(txtActualizarTelefono);
            groupBox1.Controls.Add(lblCorreoActualizar);
            groupBox1.Controls.Add(txtActualizarCorreo);
            groupBox1.Controls.Add(lblNombreActualizar);
            groupBox1.Controls.Add(txtActualizarNombre);
            groupBox1.Location = new Point(599, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 214);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(139, 167);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 33);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblIdActualizar
            // 
            lblIdActualizar.AutoSize = true;
            lblIdActualizar.Location = new Point(14, 27);
            lblIdActualizar.Name = "lblIdActualizar";
            lblIdActualizar.Size = new Size(18, 15);
            lblIdActualizar.TabIndex = 6;
            lblIdActualizar.Text = "ID";
            // 
            // txtActualizarId
            // 
            txtActualizarId.Location = new Point(14, 48);
            txtActualizarId.Name = "txtActualizarId";
            txtActualizarId.Size = new Size(149, 23);
            txtActualizarId.TabIndex = 7;
            txtActualizarId.KeyPress += txtActualizarId_KeyPress;
            // 
            // lblTelefonoActualizar
            // 
            lblTelefonoActualizar.AutoSize = true;
            lblTelefonoActualizar.Location = new Point(185, 81);
            lblTelefonoActualizar.Name = "lblTelefonoActualizar";
            lblTelefonoActualizar.Size = new Size(53, 15);
            lblTelefonoActualizar.TabIndex = 7;
            lblTelefonoActualizar.Text = "Telefono";
            // 
            // txtActualizarTelefono
            // 
            txtActualizarTelefono.Location = new Point(187, 100);
            txtActualizarTelefono.Name = "txtActualizarTelefono";
            txtActualizarTelefono.Size = new Size(189, 23);
            txtActualizarTelefono.TabIndex = 10;
            txtActualizarTelefono.TextChanged += txtActualizarTelefono_TextChanged;
            txtActualizarTelefono.KeyPress += txtActualizarTelefono_KeyPress;
            // 
            // lblCorreoActualizar
            // 
            lblCorreoActualizar.AutoSize = true;
            lblCorreoActualizar.Location = new Point(14, 81);
            lblCorreoActualizar.Name = "lblCorreoActualizar";
            lblCorreoActualizar.Size = new Size(43, 15);
            lblCorreoActualizar.TabIndex = 5;
            lblCorreoActualizar.Text = "Correo";
            // 
            // txtActualizarCorreo
            // 
            txtActualizarCorreo.Location = new Point(12, 100);
            txtActualizarCorreo.Name = "txtActualizarCorreo";
            txtActualizarCorreo.Size = new Size(151, 23);
            txtActualizarCorreo.TabIndex = 9;
            txtActualizarCorreo.TextChanged += txtActualizarCorreo_TextChanged;
            // 
            // lblNombreActualizar
            // 
            lblNombreActualizar.AutoSize = true;
            lblNombreActualizar.Location = new Point(188, 26);
            lblNombreActualizar.Name = "lblNombreActualizar";
            lblNombreActualizar.Size = new Size(51, 15);
            lblNombreActualizar.TabIndex = 3;
            lblNombreActualizar.Text = "Nombre";
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(187, 48);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(189, 23);
            txtActualizarNombre.TabIndex = 8;
            // 
            // groupBoxMostrar
            // 
            groupBoxMostrar.Controls.Add(dgvProveedores);
            groupBoxMostrar.Controls.Add(btnCargar);
            groupBoxMostrar.Location = new Point(12, 229);
            groupBoxMostrar.Name = "groupBoxMostrar";
            groupBoxMostrar.Size = new Size(992, 224);
            groupBoxMostrar.TabIndex = 11;
            groupBoxMostrar.TabStop = false;
            groupBoxMostrar.Text = "Mostrar";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(6, 61);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(980, 150);
            dgvProveedores.TabIndex = 3;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(6, 22);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(263, 33);
            btnCargar.TabIndex = 12;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Controls.Add(btnEliminar);
            groupBoxEliminar.Controls.Add(lblID);
            groupBoxEliminar.Controls.Add(txtEliminarId);
            groupBoxEliminar.Location = new Point(353, 12);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(240, 139);
            groupBoxEliminar.TabIndex = 10;
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
            groupBoxInsertar.Controls.Add(lblTelefono);
            groupBoxInsertar.Controls.Add(txtInsertTelefono);
            groupBoxInsertar.Controls.Add(lblCorreo);
            groupBoxInsertar.Controls.Add(txtInsertCorreo);
            groupBoxInsertar.Controls.Add(lblNombreProveedores);
            groupBoxInsertar.Controls.Add(btnAgregar);
            groupBoxInsertar.Controls.Add(txtInsertNombre);
            groupBoxInsertar.Location = new Point(12, 12);
            groupBoxInsertar.Name = "groupBoxInsertar";
            groupBoxInsertar.Size = new Size(335, 214);
            groupBoxInsertar.TabIndex = 9;
            groupBoxInsertar.TabStop = false;
            groupBoxInsertar.Text = "Insertar";
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
            txtInsertTelefono.Location = new Point(8, 116);
            txtInsertTelefono.Name = "txtInsertTelefono";
            txtInsertTelefono.Size = new Size(151, 23);
            txtInsertTelefono.TabIndex = 3;
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
            txtInsertCorreo.TabIndex = 2;
            txtInsertCorreo.TextChanged += txtInsertCorreo_TextChanged;
            // 
            // lblNombreProveedores
            // 
            lblNombreProveedores.AutoSize = true;
            lblNombreProveedores.Location = new Point(8, 34);
            lblNombreProveedores.Name = "lblNombreProveedores";
            lblNombreProveedores.Size = new Size(51, 15);
            lblNombreProveedores.TabIndex = 3;
            lblNombreProveedores.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(84, 167);
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 457);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxMostrar);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxInsertar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            Load += FrmProveedores_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxInsertar.ResumeLayout(false);
            groupBoxInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnActualizar;
        private Label lblIdActualizar;
        private TextBox txtActualizarId;
        private Label lblTelefonoActualizar;
        private TextBox txtActualizarTelefono;
        private Label lblCorreoActualizar;
        private TextBox txtActualizarCorreo;
        private Label lblNombreActualizar;
        private TextBox txtActualizarNombre;
        private GroupBox groupBoxMostrar;
        private DataGridView dgvProveedores;
        private Button btnCargar;
        private GroupBox groupBoxEliminar;
        private Button btnEliminar;
        private Label lblID;
        private TextBox txtEliminarId;
        private GroupBox groupBoxInsertar;
        private Label lblTelefono;
        private TextBox txtInsertTelefono;
        private Label lblCorreo;
        private TextBox txtInsertCorreo;
        private Label lblNombreProveedores;
        private Button btnAgregar;
        private TextBox txtInsertNombre;
        private ErrorProvider errorProvider1;
    }
}