namespace Gestion_de_mascotas
{
    partial class frmAgregarAnimal
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
            lblAnimal = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreAnimal = new TextBox();
            cmbEspecie = new ComboBox();
            mtxEdadAnimal = new MaskedTextBox();
            rdbHembra = new RadioButton();
            rdbMacho = new RadioButton();
            btnAceptar = new Button();
            btnCancelarAnimal = new Button();
            rdbAdoptado = new RadioButton();
            rdbLibre = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnimal.ForeColor = Color.FromArgb(106, 153, 78);
            lblAnimal.Location = new Point(27, 28);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(96, 32);
            lblAnimal.TabIndex = 0;
            lblAnimal.Text = "Animal N.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(106, 153, 78);
            label2.Location = new Point(21, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 13.7999992F);
            label3.ForeColor = Color.FromArgb(106, 153, 78);
            label3.Location = new Point(21, 139);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 2;
            label3.Text = "Especie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 13.7999992F);
            label4.ForeColor = Color.FromArgb(106, 153, 78);
            label4.Location = new Point(21, 188);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 13.7999992F);
            label5.ForeColor = Color.FromArgb(106, 153, 78);
            label5.Location = new Point(21, 240);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 4;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 13.7999992F);
            label6.ForeColor = Color.FromArgb(106, 153, 78);
            label6.Location = new Point(21, 294);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // txtNombreAnimal
            // 
            txtNombreAnimal.Location = new Point(106, 84);
            txtNombreAnimal.Margin = new Padding(3, 2, 3, 2);
            txtNombreAnimal.Name = "txtNombreAnimal";
            txtNombreAnimal.Size = new Size(260, 23);
            txtNombreAnimal.TabIndex = 6;
            txtNombreAnimal.KeyPress += txtNombreAnimal_KeyPress;
            // 
            // cmbEspecie
            // 
            cmbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { "Mamifero", "Ave", "Reptil", "Pez" });
            cmbEspecie.Location = new Point(106, 134);
            cmbEspecie.Margin = new Padding(3, 2, 3, 2);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(260, 23);
            cmbEspecie.TabIndex = 7;
            // 
            // mtxEdadAnimal
            // 
            mtxEdadAnimal.Location = new Point(106, 183);
            mtxEdadAnimal.Margin = new Padding(3, 2, 3, 2);
            mtxEdadAnimal.Mask = "00";
            mtxEdadAnimal.Name = "mtxEdadAnimal";
            mtxEdadAnimal.Size = new Size(110, 23);
            mtxEdadAnimal.TabIndex = 8;
            mtxEdadAnimal.ValidatingType = typeof(int);
            mtxEdadAnimal.MaskInputRejected += mtxEdadAnimal_MaskInputRejected;
            // 
            // rdbHembra
            // 
            rdbHembra.AutoSize = true;
            rdbHembra.Location = new Point(106, 238);
            rdbHembra.Margin = new Padding(3, 2, 3, 2);
            rdbHembra.Name = "rdbHembra";
            rdbHembra.Size = new Size(68, 19);
            rdbHembra.TabIndex = 9;
            rdbHembra.TabStop = true;
            rdbHembra.Text = "Hembra";
            rdbHembra.UseVisualStyleBackColor = true;
            // 
            // rdbMacho
            // 
            rdbMacho.AutoSize = true;
            rdbMacho.Location = new Point(212, 237);
            rdbMacho.Margin = new Padding(3, 2, 3, 2);
            rdbMacho.Name = "rdbMacho";
            rdbMacho.Size = new Size(62, 19);
            rdbMacho.TabIndex = 10;
            rdbMacho.TabStop = true;
            rdbMacho.Text = "Macho";
            rdbMacho.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(370, 313);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAgregarA_Click;
            // 
            // btnCancelarAnimal
            // 
            btnCancelarAnimal.Location = new Point(474, 313);
            btnCancelarAnimal.Margin = new Padding(3, 2, 3, 2);
            btnCancelarAnimal.Name = "btnCancelarAnimal";
            btnCancelarAnimal.Size = new Size(82, 22);
            btnCancelarAnimal.TabIndex = 13;
            btnCancelarAnimal.Text = "Cancelar";
            btnCancelarAnimal.UseVisualStyleBackColor = true;
            btnCancelarAnimal.Click += btnCancelarAnimal_Click;
            // 
            // rdbAdoptado
            // 
            rdbAdoptado.AutoSize = true;
            rdbAdoptado.Location = new Point(115, 293);
            rdbAdoptado.Margin = new Padding(3, 2, 3, 2);
            rdbAdoptado.Name = "rdbAdoptado";
            rdbAdoptado.Size = new Size(78, 19);
            rdbAdoptado.TabIndex = 14;
            rdbAdoptado.TabStop = true;
            rdbAdoptado.Text = "Adoptado";
            rdbAdoptado.UseVisualStyleBackColor = true;
            // 
            // rdbLibre
            // 
            rdbLibre.AutoSize = true;
            rdbLibre.Location = new Point(243, 291);
            rdbLibre.Margin = new Padding(3, 2, 3, 2);
            rdbLibre.Name = "rdbLibre";
            rdbLibre.Size = new Size(51, 19);
            rdbLibre.TabIndex = 15;
            rdbLibre.TabStop = true;
            rdbLibre.Text = "Libre";
            rdbLibre.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 351);
            Controls.Add(rdbLibre);
            Controls.Add(rdbAdoptado);
            Controls.Add(btnCancelarAnimal);
            Controls.Add(btnAceptar);
            Controls.Add(rdbMacho);
            Controls.Add(rdbHembra);
            Controls.Add(mtxEdadAnimal);
            Controls.Add(cmbEspecie);
            Controls.Add(txtNombreAnimal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblAnimal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(590, 390);
            MinimizeBox = false;
            MinimumSize = new Size(590, 390);
            Name = "frmAgregarAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Animal";
            Load += frmAgregarAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreAnimal;
        private ComboBox cmbEspecie;
        private MaskedTextBox mtxEdadAnimal;
        private RadioButton rdbHembra;
        private RadioButton rdbMacho;
        private Button btnAceptar;
        private Button btnCancelarAnimal;
        private RadioButton rdbAdoptado;
        private RadioButton rdbLibre;
        private ErrorProvider errorProvider1;
    }
}