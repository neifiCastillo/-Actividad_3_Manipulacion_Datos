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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            groupBoxMostrar = new GroupBox();
            dgvClientes = new DataGridView();
            btnCargar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            txtActualizarId = new TextBox();
            groupBoxEliminar = new GroupBox();
            btnEliminar = new Button();
            lblID = new Label();
            txtEliminarId = new TextBox();
            groupBoxInsertar = new GroupBox();
            label5 = new Label();
            txtInsertDireccion = new TextBox();
            label4 = new Label();
            txtInsertTelefono = new TextBox();
            label3 = new Label();
            txtInsertCorreo = new TextBox();
            lblNombreCategoria = new Label();
            btnAgregar = new Button();
            txtInsertNombre = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtActualizarDireccion = new TextBox();
            label7 = new Label();
            txtActualizarTelefono = new TextBox();
            label8 = new Label();
            txtActualizarCorreo = new TextBox();
            label9 = new Label();
            txtActualizarNombre = new TextBox();
            groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBoxEliminar.SuspendLayout();
            groupBoxInsertar.SuspendLayout();
            groupBox1.SuspendLayout();
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
            btnCargar.TabIndex = 2;
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
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // txtActualizarId
            // 
            txtActualizarId.Location = new Point(14, 48);
            txtActualizarId.Name = "txtActualizarId";
            txtActualizarId.Size = new Size(95, 23);
            txtActualizarId.TabIndex = 5;
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
            groupBoxInsertar.Controls.Add(label5);
            groupBoxInsertar.Controls.Add(txtInsertDireccion);
            groupBoxInsertar.Controls.Add(label4);
            groupBoxInsertar.Controls.Add(txtInsertTelefono);
            groupBoxInsertar.Controls.Add(label3);
            groupBoxInsertar.Controls.Add(txtInsertCorreo);
            groupBoxInsertar.Controls.Add(lblNombreCategoria);
            groupBoxInsertar.Controls.Add(btnAgregar);
            groupBoxInsertar.Controls.Add(txtInsertNombre);
            groupBoxInsertar.Location = new Point(2, 12);
            groupBoxInsertar.Name = "groupBoxInsertar";
            groupBoxInsertar.Size = new Size(335, 284);
            groupBoxInsertar.TabIndex = 4;
            groupBoxInsertar.TabStop = false;
            groupBoxInsertar.Text = "Insertar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 148);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Direccion";
            // 
            // txtInsertDireccion
            // 
            txtInsertDireccion.Location = new Point(6, 170);
            txtInsertDireccion.Name = "txtInsertDireccion";
            txtInsertDireccion.Size = new Size(322, 23);
            txtInsertDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 93);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefono";
            // 
            // txtInsertTelefono
            // 
            txtInsertTelefono.Location = new Point(6, 115);
            txtInsertTelefono.Name = "txtInsertTelefono";
            txtInsertTelefono.Size = new Size(151, 23);
            txtInsertTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 34);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Correo";
            // 
            // txtInsertCorreo
            // 
            txtInsertCorreo.Location = new Point(177, 56);
            txtInsertCorreo.Name = "txtInsertCorreo";
            txtInsertCorreo.Size = new Size(151, 23);
            txtInsertCorreo.TabIndex = 4;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(8, 34);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(51, 15);
            lblNombreCategoria.TabIndex = 3;
            lblNombreCategoria.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(92, 232);
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
            txtInsertNombre.Size = new Size(153, 23);
            txtInsertNombre.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtActualizarId);
            groupBox1.Controls.Add(txtActualizarDireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtActualizarTelefono);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtActualizarCorreo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtActualizarNombre);
            groupBox1.Location = new Point(589, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 284);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 137);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Direccion";
            // 
            // txtActualizarDireccion
            // 
            txtActualizarDireccion.Location = new Point(183, 159);
            txtActualizarDireccion.Name = "txtActualizarDireccion";
            txtActualizarDireccion.Size = new Size(322, 23);
            txtActualizarDireccion.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 137);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 7;
            label7.Text = "Telefono";
            // 
            // txtActualizarTelefono
            // 
            txtActualizarTelefono.Location = new Point(12, 159);
            txtActualizarTelefono.Name = "txtActualizarTelefono";
            txtActualizarTelefono.Size = new Size(151, 23);
            txtActualizarTelefono.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(185, 78);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 5;
            label8.Text = "Correo";
            // 
            // txtActualizarCorreo
            // 
            txtActualizarCorreo.Location = new Point(183, 100);
            txtActualizarCorreo.Name = "txtActualizarCorreo";
            txtActualizarCorreo.Size = new Size(151, 23);
            txtActualizarCorreo.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 78);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 3;
            label9.Text = "Nombre";
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(12, 100);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(153, 23);
            txtActualizarNombre.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMostrar;
        private DataGridView dgvClientes;
        private Button btnCargar;
        private Button btnActualizar;
        private Label label1;
        private TextBox txtActualizarId;
        private GroupBox groupBoxEliminar;
        private Button btnEliminar;
        private Label lblID;
        private TextBox txtEliminarId;
        private GroupBox groupBoxInsertar;
        private Label lblNombreCategoria;
        private Button btnAgregar;
        private TextBox txtInsertNombre;
        private Label label5;
        private TextBox txtInsertDireccion;
        private Label label4;
        private TextBox txtInsertTelefono;
        private Label label3;
        private TextBox txtInsertCorreo;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtActualizarDireccion;
        private Label label7;
        private TextBox txtActualizarTelefono;
        private Label label8;
        private TextBox txtActualizarCorreo;
        private Label label9;
        private TextBox txtActualizarNombre;
    }
}