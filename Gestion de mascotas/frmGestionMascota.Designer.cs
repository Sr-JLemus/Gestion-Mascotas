namespace Gestion_de_mascotas
{
    partial class frmGestionMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionMascota));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            aNIMALESToolStripMenuItem = new ToolStripMenuItem();
            aDOPCIÓNToolStripMenuItem = new ToolStripMenuItem();
            dONATIVOSToolStripMenuItem = new ToolStripMenuItem();
            eVENTOSToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(233, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(834, 279);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cuidado_de_mascotas;
            pictureBox2.Location = new Point(420, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(411, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(237, 237, 237);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aNIMALESToolStripMenuItem, aDOPCIÓNToolStripMenuItem, dONATIVOSToolStripMenuItem, eVENTOSToolStripMenuItem, sALIRToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(207, 804);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNIMALESToolStripMenuItem
            // 
            aNIMALESToolStripMenuItem.AutoSize = false;
            aNIMALESToolStripMenuItem.BackColor = Color.Transparent;
            aNIMALESToolStripMenuItem.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            aNIMALESToolStripMenuItem.ForeColor = Color.FromArgb(56, 102, 65);
            aNIMALESToolStripMenuItem.Name = "aNIMALESToolStripMenuItem";
            aNIMALESToolStripMenuItem.Size = new Size(201, 200);
            aNIMALESToolStripMenuItem.Text = "ANIMALES";
            // 
            // aDOPCIÓNToolStripMenuItem
            // 
            aDOPCIÓNToolStripMenuItem.AutoSize = false;
            aDOPCIÓNToolStripMenuItem.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold | FontStyle.Italic);
            aDOPCIÓNToolStripMenuItem.ForeColor = Color.FromArgb(56, 102, 65);
            aDOPCIÓNToolStripMenuItem.Name = "aDOPCIÓNToolStripMenuItem";
            aDOPCIÓNToolStripMenuItem.Size = new Size(201, 200);
            aDOPCIÓNToolStripMenuItem.Text = "ADOPCIÓN";
            // 
            // dONATIVOSToolStripMenuItem
            // 
            dONATIVOSToolStripMenuItem.AutoSize = false;
            dONATIVOSToolStripMenuItem.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold | FontStyle.Italic);
            dONATIVOSToolStripMenuItem.ForeColor = Color.FromArgb(56, 102, 65);
            dONATIVOSToolStripMenuItem.Name = "dONATIVOSToolStripMenuItem";
            dONATIVOSToolStripMenuItem.Size = new Size(201, 200);
            dONATIVOSToolStripMenuItem.Text = "DONATIVOS";
            // 
            // eVENTOSToolStripMenuItem
            // 
            eVENTOSToolStripMenuItem.AutoSize = false;
            eVENTOSToolStripMenuItem.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold | FontStyle.Italic);
            eVENTOSToolStripMenuItem.ForeColor = Color.FromArgb(56, 102, 65);
            eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            eVENTOSToolStripMenuItem.Size = new Size(194, 200);
            eVENTOSToolStripMenuItem.Text = "EVENTOS";
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.AutoSize = false;
            sALIRToolStripMenuItem.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold | FontStyle.Italic);
            sALIRToolStripMenuItem.ForeColor = Color.FromArgb(56, 102, 65);
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(194, 200);
            sALIRToolStripMenuItem.Text = "SALIR";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.AutoScroll = true;
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel2);
            toolStripContainer1.ContentPanel.Controls.Add(menuStrip1);
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
            toolStripContainer1.ContentPanel.Size = new Size(1082, 804);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(1082, 804);
            toolStripContainer1.TabIndex = 2;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(237, 237, 237);
            label4.Location = new Point(747, 719);
            label4.Name = "label4";
            label4.Size = new Size(136, 34);
            label4.TabIndex = 6;
            label4.Text = "EVENTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(237, 237, 237);
            label3.Location = new Point(372, 719);
            label3.Name = "label3";
            label3.Size = new Size(169, 34);
            label3.TabIndex = 5;
            label3.Text = "DONATIVOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(237, 237, 237);
            label2.Location = new Point(747, 346);
            label2.Name = "label2";
            label2.Size = new Size(184, 34);
            label2.TabIndex = 4;
            label2.Text = "ADOPCIONES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(237, 237, 237);
            label1.Location = new Point(372, 346);
            label1.Name = "label1";
            label1.Size = new Size(156, 34);
            label1.TabIndex = 3;
            label1.Text = "ANIMALES";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox4, 1, 0);
            tableLayoutPanel2.Location = new Point(233, 413);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(837, 277);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(412, 270);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(421, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(413, 270);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // frmGestionMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 153, 78);
            ClientSize = new Size(1082, 804);
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestionMascota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionMascota";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNIMALESToolStripMenuItem;
        private ToolStripMenuItem aDOPCIÓNToolStripMenuItem;
        private ToolStripMenuItem dONATIVOSToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem eVENTOSToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}