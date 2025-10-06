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
            btnAgregarA = new Button();
            btnCancelarAnimal = new Button();
            rdbAdoptado = new RadioButton();
            rdbLibre = new RadioButton();
            SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnimal.ForeColor = Color.FromArgb(106, 153, 78);
            lblAnimal.Location = new Point(31, 38);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(119, 39);
            lblAnimal.TabIndex = 0;
            lblAnimal.Text = "Animal N.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(106, 153, 78);
            label2.Location = new Point(24, 115);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 13.7999992F);
            label3.ForeColor = Color.FromArgb(106, 153, 78);
            label3.Location = new Point(24, 185);
            label3.Name = "label3";
            label3.Size = new Size(78, 33);
            label3.TabIndex = 2;
            label3.Text = "Especie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 13.7999992F);
            label4.ForeColor = Color.FromArgb(106, 153, 78);
            label4.Location = new Point(24, 251);
            label4.Name = "label4";
            label4.Size = new Size(59, 33);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 13.7999992F);
            label5.ForeColor = Color.FromArgb(106, 153, 78);
            label5.Location = new Point(24, 320);
            label5.Name = "label5";
            label5.Size = new Size(56, 33);
            label5.TabIndex = 4;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 13.7999992F);
            label6.ForeColor = Color.FromArgb(106, 153, 78);
            label6.Location = new Point(24, 392);
            label6.Name = "label6";
            label6.Size = new Size(74, 33);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // txtNombreAnimal
            // 
            txtNombreAnimal.Location = new Point(121, 112);
            txtNombreAnimal.Name = "txtNombreAnimal";
            txtNombreAnimal.Size = new Size(296, 27);
            txtNombreAnimal.TabIndex = 6;
            // 
            // cmbEspecie
            // 
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { "Mamifero", "Ave", "Reptil", "Pez" });
            cmbEspecie.Location = new Point(121, 179);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(296, 28);
            cmbEspecie.TabIndex = 7;
            // 
            // mtxEdadAnimal
            // 
            mtxEdadAnimal.Location = new Point(121, 244);
            mtxEdadAnimal.Mask = "00";
            mtxEdadAnimal.Name = "mtxEdadAnimal";
            mtxEdadAnimal.Size = new Size(125, 27);
            mtxEdadAnimal.TabIndex = 8;
            mtxEdadAnimal.ValidatingType = typeof(int);
            // 
            // rdbHembra
            // 
            rdbHembra.AutoSize = true;
            rdbHembra.Location = new Point(121, 318);
            rdbHembra.Name = "rdbHembra";
            rdbHembra.Size = new Size(84, 24);
            rdbHembra.TabIndex = 9;
            rdbHembra.TabStop = true;
            rdbHembra.Text = "Hembra";
            rdbHembra.UseVisualStyleBackColor = true;
            // 
            // rdbMacho
            // 
            rdbMacho.AutoSize = true;
            rdbMacho.Location = new Point(242, 316);
            rdbMacho.Name = "rdbMacho";
            rdbMacho.Size = new Size(75, 24);
            rdbMacho.TabIndex = 10;
            rdbMacho.TabStop = true;
            rdbMacho.Text = "Macho";
            rdbMacho.UseVisualStyleBackColor = true;
            // 
            // btnAgregarA
            // 
            btnAgregarA.Location = new Point(423, 417);
            btnAgregarA.Name = "btnAgregarA";
            btnAgregarA.Size = new Size(94, 29);
            btnAgregarA.TabIndex = 12;
            btnAgregarA.Text = "Aceptar";
            btnAgregarA.UseVisualStyleBackColor = true;
            btnAgregarA.Click += btnAgregarA_Click;
            // 
            // btnCancelarAnimal
            // 
            btnCancelarAnimal.Location = new Point(542, 417);
            btnCancelarAnimal.Name = "btnCancelarAnimal";
            btnCancelarAnimal.Size = new Size(94, 29);
            btnCancelarAnimal.TabIndex = 13;
            btnCancelarAnimal.Text = "Cancelar";
            btnCancelarAnimal.UseVisualStyleBackColor = true;
            btnCancelarAnimal.Click += btnCancelarAnimal_Click;
            // 
            // rdbAdoptado
            // 
            rdbAdoptado.AutoSize = true;
            rdbAdoptado.Location = new Point(131, 391);
            rdbAdoptado.Name = "rdbAdoptado";
            rdbAdoptado.Size = new Size(98, 24);
            rdbAdoptado.TabIndex = 14;
            rdbAdoptado.TabStop = true;
            rdbAdoptado.Text = "Adoptado";
            rdbAdoptado.UseVisualStyleBackColor = true;
            // 
            // rdbLibre
            // 
            rdbLibre.AutoSize = true;
            rdbLibre.Location = new Point(278, 388);
            rdbLibre.Name = "rdbLibre";
            rdbLibre.Size = new Size(63, 24);
            rdbLibre.TabIndex = 15;
            rdbLibre.TabStop = true;
            rdbLibre.Text = "Libre";
            rdbLibre.UseVisualStyleBackColor = true;
            // 
            // frmAgregarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 469);
            Controls.Add(rdbLibre);
            Controls.Add(rdbAdoptado);
            Controls.Add(btnCancelarAnimal);
            Controls.Add(btnAgregarA);
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
            Name = "frmAgregarAnimal";
            Text = "Agregar Animal";
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
        private Button btnAgregarA;
        private Button btnCancelarAnimal;
        private RadioButton rdbAdoptado;
        private RadioButton rdbLibre;
    }
}