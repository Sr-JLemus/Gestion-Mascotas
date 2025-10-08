using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_mascotas.EVENTOS
{
    public partial class frmAgregarEvento : Form
    {
        public string NombreEvento { get => txtEvento.Text; set => txtEvento.Text = value; }
        public DateTime FechaEvento { get => dtpDia.Value; set => dtpDia.Value = value; }
        public DateTime HoraEvento { get => dtpHora.Value; set => dtpHora.Value = value; }
        public string LugarEvento { get => txtLugar.Text; set => txtLugar.Text = value; }


        public frmAgregarEvento() => InitializeComponent();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmAgregarEvento_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;

            txtEvento.TextChanged += ValidarFormulario;
            txtLugar.TextChanged += ValidarFormulario;

            txtEvento.Focus();
        }

        private void ValidarFormulario(object? sender, EventArgs e)
        {
            bool nombreOk = !string.IsNullOrWhiteSpace(txtEvento.Text);
            bool lugarOk = !string.IsNullOrWhiteSpace(txtEvento.Text);

            errorProvider1.SetError(txtEvento, nombreOk ? "" : "El nombre del evento es obligatorio.");
            errorProvider1.SetError(txtEvento, lugarOk ? "" : "El lugar del evento es obligatorio.");

            btnAgregar.Enabled = nombreOk && lugarOk;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
