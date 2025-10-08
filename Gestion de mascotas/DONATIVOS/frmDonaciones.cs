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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDonaciones frm = new frmAgregarDonaciones();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvDonaciones.Rows.Add(
                    frm.ID,
                    frm.Donante,
                    frm.Telefono,
                    frm.Email,
                    frm.Monto,
                    frm.Fecha.ToShortDateString()

                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        
    }
}
