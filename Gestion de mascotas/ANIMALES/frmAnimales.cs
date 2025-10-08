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
        int contadorID = 1;
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            frmAgregarAnimal frm = new frmAgregarAnimal();

            frm.ID = "A" + contadorID.ToString("D3");

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

                contadorID++; 


                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Add(
                        frm.Nombre,
                        frm.Edad,
                        frm.Sexo,
                        frm.Especie,
                        frm.Estado
                    );
                }
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

        private void btnEditarAnimal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                
                frmAgregarAnimal frm = new frmAgregarAnimal();

                
                frm.Nombre = fila.Cells[0].Value.ToString();
                frm.Edad = Convert.ToInt32(fila.Cells[1].Value);
                frm.Sexo = fila.Cells[2].Value.ToString();
                frm.Especie = fila.Cells[3].Value.ToString();
                frm.Estado = fila.Cells[4].Value.ToString();
                frm.ID = fila.Cells[5].Value.ToString();

                
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    
                    fila.Cells[0].Value = frm.Nombre;
                    fila.Cells[1].Value = frm.Edad;
                    fila.Cells[2].Value = frm.Sexo;
                    fila.Cells[3].Value = frm.Especie;
                    fila.Cells[4].Value = frm.Estado;
                    fila.Cells[5].Value = frm.ID;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }
    }
}
