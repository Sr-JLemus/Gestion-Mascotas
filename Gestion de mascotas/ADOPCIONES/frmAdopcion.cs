using Gestion_de_mascotas.DONATIVOS;
using Gestion_de_mascotas.EVENTOS;
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
    public partial class frmAdopcion : Form
    {
        public frmAdopcion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAdoptante frm = new frmAgregarAdoptante();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvAdopcion.Rows.Add(
                    frm.IDAdopcion,
                    frm.NombreAdoptante,
                    frm.TelefonoAdoptante,
                    frm.EmailAdoptante,
                    frm.IDAdoptado
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdopcion.SelectedRows.Count > 0)
            {
                dgvAdopcion.Rows.RemoveAt(dgvAdopcion.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAdopcion.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAdopcion.SelectedRows[0];

                frmAgregarAdoptante frm = new frmAgregarAdoptante();

                frm.IDAdopcion = fila.Cells[0].Value.ToString();
                frm.NombreAdoptante = fila.Cells[1].Value.ToString();
                frm.TelefonoAdoptante = fila.Cells[2].Value.ToString();
                frm.EmailAdoptante = fila.Cells[3].Value.ToString();
                frm.IDAdoptado = fila.Cells[4].Value.ToString();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fila.Cells[0].Value = frm.IDAdopcion;
                    fila.Cells[1].Value = frm.NombreAdoptante;
                    fila.Cells[2].Value = frm.TelefonoAdoptante;
                    fila.Cells[3].Value = frm.EmailAdoptante;
                    fila.Cells[4].Value = frm.IDAdoptado;
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para editar.");
                }
            }
        }
    }
}
