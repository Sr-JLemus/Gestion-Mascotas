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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDonaciones.SelectedRows.Count > 0)
            {
                dgvDonaciones.Rows.RemoveAt(dgvDonaciones.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDonaciones.SelectedRows.Count > 0)
            {

                DataGridViewRow fila = dgvDonaciones.SelectedRows[0];


                frmAgregarDonaciones frm = new frmAgregarDonaciones();


                frm.ID = fila.Cells[0].Value.ToString();
                frm.Donante = fila.Cells[1].Value.ToString();
                frm.Telefono = fila.Cells[2].Value.ToString();
                frm.Email = fila.Cells[3].Value.ToString();
                frm.Monto = Convert.ToDecimal(fila.Cells[4].Value);
                frm.Fecha = Convert.ToDateTime(fila.Cells[5].Value);


                if (frm.ShowDialog() == DialogResult.OK)
                {

                    fila.Cells[0].Value = frm.ID;
                    fila.Cells[1].Value = frm.Donante;
                    fila.Cells[2].Value = frm.Telefono;
                    fila.Cells[3].Value = frm.Email;
                    fila.Cells[4].Value = frm.Monto;
                    fila.Cells[5].Value = frm.Fecha.ToShortDateString();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.ToLower();
            foreach (DataGridViewRow fila in dgvDonaciones.Rows)
            {
                bool visible = fila.Cells[1].Value.ToString().ToLower().Contains(criterio) ||
                               fila.Cells[3].Value.ToString().ToLower().Contains(criterio);
                fila.Visible = visible;
            }

        }
    }
}
