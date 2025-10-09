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
    public partial class frmAnimales : Form
    {

        public frmAnimales()
        {
            InitializeComponent();
        }

        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            frmAgregarAnimal frm = new frmAgregarAnimal();



            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(
                   frm.ID,
                   frm.Nombre,
                   frm.Edad,
                   frm.Sexo,
                   frm.Especie,
                   frm.Estado
               );
            }
        }


        private void btnSalirAnimales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarAnimales_Click(object sender, EventArgs e)
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
                
                frmAgregarAnimal frm = new frmAgregarAnimal();

    }
}
