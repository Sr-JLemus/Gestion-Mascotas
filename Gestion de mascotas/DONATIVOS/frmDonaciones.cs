using Gestion_de_mascotas.DONATIVOS;
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
    public partial class frmDonaciones : Form
    {

        public frmDonaciones()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDonaciones frm = new frmAgregarDonaciones();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvDonaciones.Rows.Add(
                    frm.Donaciones.ID,
                    frm.Donaciones.Donante,
                    frm.Donaciones.Telefono,
                    frm.Donaciones.Email,
                    frm.Donaciones.Monto,
                    frm.Donaciones.Fecha
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        
    }
}
