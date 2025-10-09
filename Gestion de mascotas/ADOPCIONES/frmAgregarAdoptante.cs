using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_mascotas
{
    public partial class frmAgregarAdoptante : Form
    {
        public string IDAdopcion { get => txtIDAdopcion.Text; set => txtIDAdopcion.Text = value; }
        public string IDAdoptado { get => txtIDAdoptado.Text; set => txtIDAdoptado.Text = value; }
        public string NombreAdoptante { get => txtNombreAdoptante.Text; set => txtNombreAdoptante.Text = value; }
        public string TelefonoAdoptante { get => mtxTelefonoAdoptante.Text; set => mtxTelefonoAdoptante.Text = value; }
        public string EmailAdoptante { get => txtEmailAdoptante.Text; set => txtEmailAdoptante.Text = value; }
        public frmAgregarAdoptante() => InitializeComponent();
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
        private void btnGuardar_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        //ahora se validan los datos del formulario
        private void frmAgregarAdoptante_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;

            txtIDAdopcion.Focus();
            txtNombreAdoptante.TextChanged += ValidarFormulario;
            txtEmailAdoptante.TextChanged += ValidarFormulario;
            mtxTelefonoAdoptante.TextChanged += ValidarFormulario;
            txtIDAdoptado.TextChanged += ValidarFormulario;
        }
        public void ValidarFormulario(object? sender, EventArgs e)
        {
            bool idOk = !string.IsNullOrWhiteSpace(txtIDAdopcion.Text);
            bool NombreOK = !string.IsNullOrWhiteSpace(txtNombreAdoptante.Text);
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool emailOK = !string.IsNullOrWhiteSpace(txtEmailAdoptante.Text) && Regex.IsMatch(txtEmailAdoptante.Text, patronCorreo);
            bool telefonoOk = mtxTelefonoAdoptante.MaskFull && mtxTelefonoAdoptante.Text.Length == 9;
            bool IDAdoptadoOk = !string.IsNullOrWhiteSpace(txtIDAdoptado.Text);

            errorProvider1.SetError(txtNombreAdoptante, NombreOK ? "" : "El nombre es obligatorio.");
            errorProvider1.SetError(txtIDAdopcion, idOk ? "" : "Debe añadir una ID de adopción.");
            errorProvider1.SetError(txtEmailAdoptante, emailOK ? "" : "El correo ingresado no es válido.");
            errorProvider1.SetError(mtxTelefonoAdoptante, telefonoOk ? "" : "El teléfono no es válido.");
            errorProvider1.SetError(txtIDAdoptado, IDAdoptadoOk ? "" : "La ID del animal adoptado es obligatoria.");

            btnGuardar.Enabled = idOk && NombreOK && emailOK && IDAdoptadoOk && telefonoOk;
        }

        private void mtxTelefonoAdoptante_Click(object sender, EventArgs e)
        {
            mtxTelefonoAdoptante.SelectionStart = 0;
        }

        private void txtNombreAdoptante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                return;

            e.Handled = true;
        }
    }
}
