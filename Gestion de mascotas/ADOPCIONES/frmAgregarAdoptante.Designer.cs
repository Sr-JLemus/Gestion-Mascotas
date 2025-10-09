namespace Gestion_de_mascotas
{
    partial class frmAgregarAdoptante
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            lblID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIDAdoptado = new TextBox();
            txtIDAdopcion = new TextBox();
            txtNombreAdoptante = new TextBox();
            mtxTelefonoAdoptante = new MaskedTextBox();
            txtEmailAdoptante = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(162, 271);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(277, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(22, 75);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            lblID.ForeColor = SystemColors.ControlLightLight;
            lblID.Location = new Point(21, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(98, 21);
            lblID.TabIndex = 3;
            lblID.Text = "ID adopción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(22, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 4;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(22, 172);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 5;
            label3.Text = "E mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(22, 223);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 6;
            label4.Text = "ID a quien adopta:";
            // 
            // txtIDAdoptado
            // 
            txtIDAdoptado.Location = new Point(163, 220);
            txtIDAdoptado.Name = "txtIDAdoptado";
            txtIDAdoptado.Size = new Size(120, 23);
            txtIDAdoptado.TabIndex = 7;
            // 
            // txtIDAdopcion
            // 
            txtIDAdopcion.Location = new Point(162, 27);
            txtIDAdopcion.Name = "txtIDAdopcion";
            txtIDAdopcion.Size = new Size(120, 23);
            txtIDAdopcion.TabIndex = 8;
            // 
            // txtNombreAdoptante
            // 
            txtNombreAdoptante.Location = new Point(162, 72);
            txtNombreAdoptante.Name = "txtNombreAdoptante";
            txtNombreAdoptante.Size = new Size(189, 23);
            txtNombreAdoptante.TabIndex = 9;
            txtNombreAdoptante.KeyPress += txtNombreAdoptante_KeyPress;
            // 
            // mtxTelefonoAdoptante
            // 
            mtxTelefonoAdoptante.Location = new Point(163, 119);
            mtxTelefonoAdoptante.Mask = "0000-0000";
            mtxTelefonoAdoptante.Name = "mtxTelefonoAdoptante";
            mtxTelefonoAdoptante.Size = new Size(120, 23);
            mtxTelefonoAdoptante.TabIndex = 11;
            mtxTelefonoAdoptante.Click += mtxTelefonoAdoptante_Click;
            // 
            // txtEmailAdoptante
            // 
            txtEmailAdoptante.Location = new Point(162, 169);
            txtEmailAdoptante.Name = "txtEmailAdoptante";
            txtEmailAdoptante.Size = new Size(190, 23);
            txtEmailAdoptante.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregarAdoptante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(396, 313);
            Controls.Add(txtEmailAdoptante);
            Controls.Add(mtxTelefonoAdoptante);
            Controls.Add(txtNombreAdoptante);
            Controls.Add(txtIDAdopcion);
            Controls.Add(txtIDAdoptado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            MaximizeBox = false;
            Name = "frmAgregarAdoptante";
            Text = "Agregar adopción";
            Load += frmAgregarAdoptante_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private Label lblID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIDAdoptado;
        private TextBox txtIDAdopcion;
        private TextBox txtNombreAdoptante;
        private MaskedTextBox mtxTelefonoAdoptante;
        private TextBox txtEmailAdoptante;
        private ErrorProvider errorProvider1;
    }
}