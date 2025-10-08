using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_mascotas
{
    public partial class frmGestionMascota : Form
    {
        public frmGestionMascota()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dONATIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir formulario donaciones
            frmDonaciones frmDonaciones = new frmDonaciones();
            frmDonaciones.ShowDialog();
            frmDonaciones.Dispose();
        }

        private void aNIMALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimales frmAnimales = new frmAnimales();
            frmAnimales.ShowDialog();
            frmAnimales.Dispose();
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventos frmEventos = new frmEventos();
            frmEventos.ShowDialog();
            frmEventos.Dispose();
        }
    }
}