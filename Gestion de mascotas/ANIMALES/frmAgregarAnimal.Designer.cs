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
            txtIDAnimal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(237, 237, 237);
            label2.Location = new Point(24, 115);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(237, 237, 237);
            label3.Location = new Point(24, 185);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Especie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(237, 237, 237);
            label4.Location = new Point(24, 251);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 3;
            label4.Text = "Edad (meses)";
//            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(237, 237, 237);
            label5.Location = new Point(24, 320);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 4;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(237, 237, 237);
            label6.Location = new Point(24, 392);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
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
            rdbHembra.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            rdbHembra.ForeColor = Color.FromArgb(237, 237, 237);
            rdbHembra.Location = new Point(121, 317);
            rdbHembra.Name = "rdbHembra";
            rdbHembra.Size = new Size(103, 29);
            rdbHembra.TabIndex = 9;
            rdbHembra.TabStop = true;
            rdbHembra.Text = "Hembra";
            rdbHembra.UseVisualStyleBackColor = true;
            // 
            // rdbMacho
            // 
            rdbMacho.AutoSize = true;
            rdbMacho.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            rdbMacho.ForeColor = Color.FromArgb(237, 237, 237);
            rdbMacho.Location = new Point(242, 316);
            rdbMacho.Name = "rdbMacho";
            rdbMacho.Size = new Size(90, 29);
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
            chkAdoptado.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            chkAdoptado.ForeColor = Color.FromArgb(237, 237, 237);
            chkAdoptado.Location = new Point(121, 401);
            chkAdoptado.Name = "chkAdoptado";
            chkAdoptado.Size = new Size(116, 29);
            chkAdoptado.TabIndex = 14;
            chkAdoptado.Text = "Adoptado";
            chkAdoptado.UseVisualStyleBackColor = true;
            // 
            // chkLibre
            // 
            chkLibre.AutoSize = true;
            chkLibre.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            chkLibre.ForeColor = Color.FromArgb(237, 237, 237);
            chkLibre.Location = new Point(263, 401);
            chkLibre.Name = "chkLibre";
            chkLibre.Size = new Size(79, 29);
            chkLibre.TabIndex = 15;
            chkLibre.Text = "Libre";
            chkLibre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(237, 237, 237);
            label1.Location = new Point(30, 58);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 16;
            label1.Text = "ANIMAL N.";
            // 
            // txtIDAnimal
            // 
            txtIDAnimal.Location = new Point(171, 59);
            txtIDAnimal.Name = "txtIDAnimal";
            txtIDAnimal.Size = new Size(125, 27);
            txtIDAnimal.TabIndex = 17;
            // 
            // frmAgregarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(649, 452);
            Controls.Add(txtIDAnimal);
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
        private TextBox txtIDAnimal;
    }
}