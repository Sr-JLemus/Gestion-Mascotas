namespace Gestion_de_mascotas
{
    partial class frmDonaciones
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
            dgvDonaciones = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Donante = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDonaciones
            // 
            dgvDonaciones.AllowUserToAddRows = false;
            dgvDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonaciones.Columns.AddRange(new DataGridViewColumn[] { ID, Donante, Telefono, Email, Monto, Fecha });
            dgvDonaciones.Dock = DockStyle.Fill;
            dgvDonaciones.Location = new Point(3, 62);
            dgvDonaciones.Name = "dgvDonaciones";
            dgvDonaciones.ReadOnly = true;
            dgvDonaciones.RowHeadersWidth = 51;
            dgvDonaciones.Size = new Size(803, 527);
            dgvDonaciones.TabIndex = 0;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Donante
            // 
            Donante.Frozen = true;
            Donante.HeaderText = "Donante";
            Donante.MinimumWidth = 6;
            Donante.Name = "Donante";
            Donante.ReadOnly = true;
            Donante.Width = 125;
            // 
            // Telefono
            // 
            Telefono.Frozen = true;
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Email
            // 
            Email.Frozen = true;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(497, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(103, 13);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(679, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(203, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(303, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(188, 27);
            txtBuscar.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(3, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDonaciones, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(809, 592);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnBuscar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 53);
            panel1.TabIndex = 1;
            // 
            // frmDonaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(809, 592);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(831, 643);
            MinimizeBox = false;
            MinimumSize = new Size(831, 643);
            Name = "frmDonaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donaciones";
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDonaciones;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Donante;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}