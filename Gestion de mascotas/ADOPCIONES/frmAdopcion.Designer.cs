namespace Gestion_de_mascotas
{
    partial class frmAdopcion
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
            dgvAdopcion = new DataGridView();
            clmIDAdoptante = new DataGridViewTextBoxColumn();
            clmNombreAdoptante = new DataGridViewTextBoxColumn();
            clmTelefonoAdoptante = new DataGridViewTextBoxColumn();
            clmEmailAdoptante = new DataGridViewTextBoxColumn();
            clmIDAdoptado = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdopcion).BeginInit();
            SuspendLayout();
            // 
            // dgvAdopcion
            // 
            dgvAdopcion.AllowUserToAddRows = false;
            dgvAdopcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdopcion.Columns.AddRange(new DataGridViewColumn[] { clmIDAdoptante, clmNombreAdoptante, clmTelefonoAdoptante, clmEmailAdoptante, clmIDAdoptado });
            dgvAdopcion.Location = new Point(12, 12);
            dgvAdopcion.Name = "dgvAdopcion";
            dgvAdopcion.Size = new Size(676, 194);
            dgvAdopcion.TabIndex = 0;
            // 
            // clmIDAdoptante
            // 
            clmIDAdoptante.HeaderText = "ID";
            clmIDAdoptante.Name = "clmIDAdoptante";
            clmIDAdoptante.ReadOnly = true;
            // 
            // clmNombreAdoptante
            // 
            clmNombreAdoptante.HeaderText = "Nombre Adoptante";
            clmNombreAdoptante.Name = "clmNombreAdoptante";
            clmNombreAdoptante.ReadOnly = true;
            clmNombreAdoptante.Width = 150;
            // 
            // clmTelefonoAdoptante
            // 
            clmTelefonoAdoptante.HeaderText = "Telefono";
            clmTelefonoAdoptante.Name = "clmTelefonoAdoptante";
            clmTelefonoAdoptante.ReadOnly = true;
            // 
            // clmEmailAdoptante
            // 
            clmEmailAdoptante.HeaderText = "E mail";
            clmEmailAdoptante.Name = "clmEmailAdoptante";
            clmEmailAdoptante.ReadOnly = true;
            clmEmailAdoptante.Width = 150;
            // 
            // clmIDAdoptado
            // 
            clmIDAdoptado.HeaderText = "ID Adoptado:";
            clmIDAdoptado.Name = "clmIDAdoptado";
            clmIDAdoptado.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(339, 248);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(431, 248);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(613, 248);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(522, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmAdopcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(700, 290);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvAdopcion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdopcion";
            Text = "frmAdopcion";
            ((System.ComponentModel.ISupportInitialize)dgvAdopcion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdopcion;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnSalir;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn clmIDAdoptante;
        private DataGridViewTextBoxColumn clmNombreAdoptante;
        private DataGridViewTextBoxColumn clmTelefonoAdoptante;
        private DataGridViewTextBoxColumn clmEmailAdoptante;
        private DataGridViewTextBoxColumn clmIDAdoptado;
    }
}