namespace Gestion_de_mascotas
{
    partial class frmEventos
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnEvento = new Button();
            btnEditarEvento = new Button();
            btnEliminarEvento = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(26, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(593, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = " Día";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Hora";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Lugar";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // btnEvento
            // 
            btnEvento.Location = new Point(195, 399);
            btnEvento.Name = "btnEvento";
            btnEvento.Size = new Size(197, 29);
            btnEvento.TabIndex = 1;
            btnEvento.Text = "Agregar un nuevo evento";
            btnEvento.UseVisualStyleBackColor = true;
            btnEvento.Click += btnEvento_Click;
            // 
            // btnEditarEvento
            // 
            btnEditarEvento.Location = new Point(421, 399);
            btnEditarEvento.Name = "btnEditarEvento";
            btnEditarEvento.Size = new Size(94, 29);
            btnEditarEvento.TabIndex = 2;
            btnEditarEvento.Text = "Editar";
            btnEditarEvento.UseVisualStyleBackColor = true;
            btnEditarEvento.Click += btnEditarEvento_Click;
            // 
            // btnEliminarEvento
            // 
            btnEliminarEvento.Location = new Point(554, 399);
            btnEliminarEvento.Name = "btnEliminarEvento";
            btnEliminarEvento.Size = new Size(94, 29);
            btnEliminarEvento.TabIndex = 3;
            btnEliminarEvento.Text = "Eliminar";
            btnEliminarEvento.UseVisualStyleBackColor = true;
            btnEliminarEvento.Click += btnEliminarEvento_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(682, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminarEvento);
            Controls.Add(btnEditarEvento);
            Controls.Add(btnEvento);
            Controls.Add(dataGridView1);
            Name = "frmEventos";
            Text = "Eventos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnEvento;
        private Button btnEditarEvento;
        private Button btnEliminarEvento;
        private Button btnSalir;
    }
}