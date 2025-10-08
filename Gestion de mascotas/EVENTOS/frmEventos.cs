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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            frmAgregarEvento frm = new frmAgregarEvento();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(
                    frm.NombreEvento,
                    frm.FechaEvento.ToShortDateString(),
                    frm.HoraEvento.ToShortTimeString(),
                    frm.LugarEvento
                );
            }
        }

        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                frmAgregarEvento frm = new frmAgregarEvento();

                frm.NombreEvento = fila.Cells[0].Value.ToString();
                frm.FechaEvento = Convert.ToDateTime(fila.Cells[1].Value);
                frm.HoraEvento = Convert.ToDateTime(fila.Cells[2].Value);
                frm.LugarEvento = fila.Cells[3].Value.ToString();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fila.Cells[0].Value = frm.NombreEvento;
                    fila.Cells[1].Value = frm.FechaEvento.ToShortDateString();
                    fila.Cells[2].Value = frm.HoraEvento.ToShortTimeString();
                    fila.Cells[3].Value = frm.LugarEvento;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
