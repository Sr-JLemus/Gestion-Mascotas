namespace Gestion_de_mascotas
{
    partial class frmAnimales
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
            btnAgregarAnimal = new Button();
            btnSalirAnimales = new Button();
            btnEliminarAnimales = new Button();
            btnEditarAnimal = new Button();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregarAnimal
            // 
            btnAgregarAnimal.Location = new Point(218, 409);
            btnAgregarAnimal.Name = "btnAgregarAnimal";
            btnAgregarAnimal.Size = new Size(177, 29);
            btnAgregarAnimal.TabIndex = 1;
            btnAgregarAnimal.Text = "Agregar un animal";
            btnAgregarAnimal.UseVisualStyleBackColor = true;
            btnAgregarAnimal.Click += btnAgregarAnimal_Click;
            // 
            // btnSalirAnimales
            // 
            btnSalirAnimales.Location = new Point(673, 409);
            btnSalirAnimales.Name = "btnSalirAnimales";
            btnSalirAnimales.Size = new Size(94, 29);
            btnSalirAnimales.TabIndex = 2;
            btnSalirAnimales.Text = "Salir";
            btnSalirAnimales.UseVisualStyleBackColor = true;
            btnSalirAnimales.Click += btnSalirAnimales_Click;
            // 
            // btnEliminarAnimales
            // 
            btnEliminarAnimales.Location = new Point(562, 409);
            btnEliminarAnimales.Name = "btnEliminarAnimales";
            btnEliminarAnimales.Size = new Size(94, 29);
            btnEliminarAnimales.TabIndex = 3;
            btnEliminarAnimales.Text = "Eliminar";
            btnEliminarAnimales.UseVisualStyleBackColor = true;
            btnEliminarAnimales.Click += btnEliminarAnimales_Click;
            // 
            // btnEditarAnimal
            // 
            btnEditarAnimal.Location = new Point(432, 409);
            btnEditarAnimal.Name = "btnEditarAnimal";
            btnEditarAnimal.Size = new Size(94, 29);
            btnEditarAnimal.TabIndex = 4;
            btnEditarAnimal.Text = "Editar";
            btnEditarAnimal.UseVisualStyleBackColor = true;
            btnEditarAnimal.Click += btnEditarAnimal_Click;
            // 
            // Column6
            // 
            Column6.HeaderText = "ID";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
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
            Column2.HeaderText = "Especie";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // frmAnimales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(797, 444);
            Controls.Add(btnEditarAnimal);
            Controls.Add(btnEliminarAnimales);
            Controls.Add(btnSalirAnimales);
            Controls.Add(btnAgregarAnimal);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MaximumSize = new Size(815, 491);
            MinimizeBox = false;
            MinimumSize = new Size(815, 491);
            Name = "frmAnimales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregarAnimal;
        private Button btnSalirAnimales;
        private Button btnEliminarAnimales;
        private Button btnEditarAnimal;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}