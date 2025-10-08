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
            errorProvider1 = new ErrorProvider(components);
            chkAdoptado = new CheckBox();
            chkLibre = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnimal.ForeColor = Color.Black;
            lblAnimal.Location = new Point(162, 58);
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
            label4.Size = new Size(132, 33);
            label4.TabIndex = 3;
            label4.Text = "Edad (meses)";
            label4.Click += label4_Click;
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
            txtNombreAnimal.Size = new Size(297, 27);
            txtNombreAnimal.TabIndex = 6;
            txtNombreAnimal.KeyPress += txtNombreAnimal_KeyPress;
            // 
            // cmbEspecie
            // 
            cmbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { "Mamifero", "Ave", "Reptil", "Pez" });
            cmbEspecie.Location = new Point(121, 179);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(297, 28);
            cmbEspecie.TabIndex = 7;
            // 
            // mtxEdadAnimal
            // 
            mtxEdadAnimal.Location = new Point(162, 257);
            mtxEdadAnimal.Mask = "00";
            mtxEdadAnimal.Name = "mtxEdadAnimal";
            mtxEdadAnimal.Size = new Size(125, 27);
            mtxEdadAnimal.TabIndex = 8;
            mtxEdadAnimal.ValidatingType = typeof(int);
            mtxEdadAnimal.MaskInputRejected += mtxEdadAnimal_MaskInputRejected;
            // 
            // rdbHembra
            // 
            rdbHembra.AutoSize = true;
            rdbHembra.Location = new Point(121, 317);
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
            // btnAceptar
            // 
            btnAceptar.Location = new Point(423, 417);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAgregarA_Click;
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
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // chkAdoptado
            // 
            chkAdoptado.AutoSize = true;
            chkAdoptado.Location = new Point(121, 401);
            chkAdoptado.Name = "chkAdoptado";
            chkAdoptado.Size = new Size(99, 24);
            chkAdoptado.TabIndex = 14;
            chkAdoptado.Text = "Adoptado";
            chkAdoptado.UseVisualStyleBackColor = true;
            // 
            // chkLibre
            // 
            chkLibre.AutoSize = true;
            chkLibre.Location = new Point(263, 401);
            chkLibre.Name = "chkLibre";
            chkLibre.Size = new Size(64, 24);
            chkLibre.TabIndex = 15;
            chkLibre.Text = "Libre";
            chkLibre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 16.1999989F);
            label1.ForeColor = Color.FromArgb(106, 153, 78);
            label1.Location = new Point(30, 58);
            label1.Name = "label1";
            label1.Size = new Size(132, 39);
            label1.TabIndex = 16;
            label1.Text = "ANIMAL N.";
            // 
            // frmAgregarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 452);
            Controls.Add(label1);
            Controls.Add(chkLibre);
            Controls.Add(chkAdoptado);
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
            MaximizeBox = false;
            MaximumSize = new Size(671, 503);
            MinimizeBox = false;
            MinimumSize = new Size(671, 503);
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
        private ErrorProvider errorProvider1;
        private CheckBox chkLibre;
        private CheckBox chkAdoptado;
        private Label label1;
    }
}