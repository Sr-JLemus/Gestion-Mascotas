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
        private RepositorioDonaciones repo;
        public frmDonaciones()
        {
            InitializeComponent();
            repo = new RepositorioDonaciones();
            repo.GenerarDonaciones(20);
            dgvDonaciones.DataSource = repo.Donaciones;

            dgvDonaciones.AutoGenerateColumns = false;
            dgvDonaciones.MultiSelect = false;
            dgvDonaciones.RowHeadersWidth = 50;
            dgvDonaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmDonaciones_Shown(object sender, EventArgs e)
        {
            dgvDonaciones.ClearSelection();
        }

        private void ActualizarDataGrid(int index = 0)
        {
            if (dgvDonaciones.Rows.Count > 0)
            {
                dgvDonaciones.ClearSelection();
                dgvDonaciones.CurrentCell = dgvDonaciones.Rows[index].Cells[0];
                dgvDonaciones.Rows[index].Selected = true;
                dgvDonaciones.FirstDisplayedScrollingRowIndex = index;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using var frm = new frmAgregarDonaciones(repo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                repo.Agregar(frm.Donaciones);
                int lastIndex = dgvDonaciones.Rows.Count - 1;
                ActualizarDataGrid(lastIndex);
                MessageBox.Show("Donación agregada exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
