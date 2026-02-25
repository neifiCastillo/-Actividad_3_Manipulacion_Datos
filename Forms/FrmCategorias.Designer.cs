namespace PracticaWinFormsTienda.Forms
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            groupBoxInsertar = new GroupBox();
            lblNombreCategoria = new Label();
            btnAgregar = new Button();
            txtInsertNombre = new TextBox();
            lblID = new Label();
            txtEliminarId = new TextBox();
            groupBoxEliminar = new GroupBox();
            btnEliminar = new Button();
            groupBoxActualizar = new GroupBox();
            btnActualizar = new Button();
            label2 = new Label();
            txtActualizarNombre = new TextBox();
            label1 = new Label();
            txtActualizarId = new TextBox();
            btnCargar = new Button();
            groupBoxMostrar = new GroupBox();
            dgvCategorias = new DataGridView();
            groupBoxInsertar.SuspendLayout();
            groupBoxEliminar.SuspendLayout();
            groupBoxActualizar.SuspendLayout();
            groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInsertar
            // 
            groupBoxInsertar.Controls.Add(lblNombreCategoria);
            groupBoxInsertar.Controls.Add(btnAgregar);
            groupBoxInsertar.Controls.Add(txtInsertNombre);
            groupBoxInsertar.Location = new Point(12, 13);
            groupBoxInsertar.Name = "groupBoxInsertar";
            groupBoxInsertar.Size = new Size(302, 139);
            groupBoxInsertar.TabIndex = 0;
            groupBoxInsertar.TabStop = false;
            groupBoxInsertar.Text = "Insertar";
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
            btnAgregar.Location = new Point(67, 99);
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
            txtInsertNombre.Size = new Size(288, 23);
            txtInsertNombre.TabIndex = 0;
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
            // groupBoxEliminar
            // 
            groupBoxEliminar.Controls.Add(btnEliminar);
            groupBoxEliminar.Controls.Add(lblID);
            groupBoxEliminar.Controls.Add(txtEliminarId);
            groupBoxEliminar.Location = new Point(320, 13);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(240, 139);
            groupBoxEliminar.TabIndex = 1;
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
            // groupBoxActualizar
            // 
            groupBoxActualizar.Controls.Add(btnActualizar);
            groupBoxActualizar.Controls.Add(label2);
            groupBoxActualizar.Controls.Add(txtActualizarNombre);
            groupBoxActualizar.Controls.Add(label1);
            groupBoxActualizar.Controls.Add(txtActualizarId);
            groupBoxActualizar.Location = new Point(566, 13);
            groupBoxActualizar.Name = "groupBoxActualizar";
            groupBoxActualizar.Size = new Size(437, 139);
            groupBoxActualizar.TabIndex = 2;
            groupBoxActualizar.TabStop = false;
            groupBoxActualizar.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(156, 99);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 33);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(120, 56);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(296, 23);
            txtActualizarNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // txtActualizarId
            // 
            txtActualizarId.Location = new Point(8, 56);
            txtActualizarId.Name = "txtActualizarId";
            txtActualizarId.Size = new Size(95, 23);
            txtActualizarId.TabIndex = 5;
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
            // groupBoxMostrar
            // 
            groupBoxMostrar.Controls.Add(dgvCategorias);
            groupBoxMostrar.Controls.Add(btnCargar);
            groupBoxMostrar.Location = new Point(12, 167);
            groupBoxMostrar.Name = "groupBoxMostrar";
            groupBoxMostrar.Size = new Size(991, 224);
            groupBoxMostrar.TabIndex = 3;
            groupBoxMostrar.TabStop = false;
            groupBoxMostrar.Text = "Mostrar";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(6, 61);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(979, 150);
            dgvCategorias.TabIndex = 3;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 400);
            Controls.Add(groupBoxMostrar);
            Controls.Add(groupBoxActualizar);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxInsertar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += FrmCategorias_Load;
            groupBoxInsertar.ResumeLayout(false);
            groupBoxInsertar.PerformLayout();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxActualizar.ResumeLayout(false);
            groupBoxActualizar.PerformLayout();
            groupBoxMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInsertar;
        private GroupBox groupBoxEliminar;
        private GroupBox groupBoxActualizar;
        private Label lblID;
        private Label lblNombreCategoria;
        private Button btnAgregar;
        private TextBox txtEliminarId;
        private TextBox txtInsertNombre;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtActualizarId;
        private Button btnActualizar;
        private Label label2;
        private TextBox txtActualizarNombre;
        private Button btnCargar;
        private GroupBox groupBoxMostrar;
        private DataGridView dgvCategorias;
    }
}