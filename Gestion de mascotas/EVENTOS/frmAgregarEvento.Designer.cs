namespace Gestion_de_mascotas.EVENTOS
{
    partial class frmAgregarEvento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEvento = new TextBox();
            txtLugar = new TextBox();
            dtpDia = new DateTimePicker();
            dtpHora = new DateTimePicker();
            btnAgregar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(237, 237, 237);
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(237, 237, 237);
            label2.Location = new Point(30, 131);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = " Día";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(237, 237, 237);
            label3.Location = new Point(30, 208);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 12.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(237, 237, 237);
            label4.Location = new Point(30, 285);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Lugar";
            // 
            // txtEvento
            // 
            txtEvento.Location = new Point(229, 64);
            txtEvento.Name = "txtEvento";
            txtEvento.Size = new Size(257, 27);
            txtEvento.TabIndex = 4;
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(108, 286);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(254, 27);
            txtLugar.TabIndex = 5;
            // 
            // dtpDia
            // 
            dtpDia.Format = DateTimePickerFormat.Short;
            dtpDia.Location = new Point(108, 132);
            dtpDia.Name = "dtpDia";
            dtpDia.Size = new Size(250, 27);
            dtpDia.TabIndex = 6;
            dtpDia.ValueChanged += dtpDia_ValueChanged;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(123, 200);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(250, 27);
            dtpHora.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(445, 377);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(592, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregarEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(723, 421);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpHora);
            Controls.Add(dtpDia);
            Controls.Add(txtLugar);
            Controls.Add(txtEvento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgregarEvento";
            Text = "frmAgregarEvento";
            Load += frmAgregarEvento_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEvento;
        private TextBox txtLugar;
        private DateTimePicker dtpDia;
        private DateTimePicker dtpHora;
        private Button btnAgregar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}