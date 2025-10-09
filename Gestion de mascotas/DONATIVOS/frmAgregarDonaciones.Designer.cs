namespace Gestion_de_mascotas.DONATIVOS
{
    partial class frmAgregarDonaciones
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
            label1 = new Label();
            txtDonante = new TextBox();
            mtxTelefono = new MaskedTextBox();
            txtEmail = new TextBox();
            txtMonto = new TextBox();
            dtpFechaDonacion = new DateTimePicker();
            txtID = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(237, 237, 237);
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 5;
            label2.Text = "Donante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(237, 237, 237);
            label3.Location = new Point(24, 120);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 6;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(237, 237, 237);
            label4.Location = new Point(24, 164);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(237, 237, 237);
            label5.Location = new Point(24, 214);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 8;
            label5.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(237, 237, 237);
            label6.Location = new Point(24, 258);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 9;
            label6.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(237, 237, 237);
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // txtDonante
            // 
            txtDonante.Location = new Point(112, 75);
            txtDonante.Margin = new Padding(3, 2, 3, 2);
            txtDonante.Name = "txtDonante";
            txtDonante.Size = new Size(275, 23);
            txtDonante.TabIndex = 10;
            txtDonante.KeyPress += txtDonante_KeyPress;
            // 
            // mtxTelefono
            // 
            mtxTelefono.Location = new Point(112, 118);
            mtxTelefono.Margin = new Padding(3, 2, 3, 2);
            mtxTelefono.Mask = "0000-0000";
            mtxTelefono.Name = "mtxTelefono";
            mtxTelefono.Size = new Size(109, 23);
            mtxTelefono.TabIndex = 11;
            mtxTelefono.Click += mtxTelefono_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(112, 163);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(112, 212);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(109, 23);
            txtMonto.TabIndex = 13;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // dtpFechaDonacion
            // 
            dtpFechaDonacion.Format = DateTimePickerFormat.Short;
            dtpFechaDonacion.Location = new Point(112, 256);
            dtpFechaDonacion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaDonacion.Name = "dtpFechaDonacion";
            dtpFechaDonacion.Size = new Size(109, 23);
            dtpFechaDonacion.TabIndex = 14;
            // 
            // txtID
            // 
            txtID.Location = new Point(112, 34);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(109, 23);
            txtID.TabIndex = 15;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(112, 306);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 306);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregarDonaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(427, 349);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtID);
            Controls.Add(dtpFechaDonacion);
            Controls.Add(txtMonto);
            Controls.Add(txtEmail);
            Controls.Add(mtxTelefono);
            Controls.Add(txtDonante);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAgregarDonaciones";
            Text = "Agregar Donaciones";
            Load += frmAgregarDonaciones_Load;
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
        private Label label1;
        private TextBox txtDonante;
        private MaskedTextBox mtxTelefono;
        private TextBox txtEmail;
        private TextBox txtMonto;
        private DateTimePicker dtpFechaDonacion;
        private TextBox txtID;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}