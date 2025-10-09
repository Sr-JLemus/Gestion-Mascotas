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

namespace Gestion_de_mascotas.DONATIVOS
{
    public partial class frmAgregarDonaciones : Form
    {
        public string ID { get => txtID.Text; set => txtID.Text = value; }
        public string Donante { get => txtDonante.Text; set => txtDonante.Text = value; }
        public string Telefono { get => mtxTelefono.Text; set => mtxTelefono.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public decimal Monto
        {
            get
            {
                decimal monto;
                if (decimal.TryParse(txtMonto.Text, out monto))
                    return monto;
                return 0;
            }
            set
            {
                txtMonto.Text = value.ToString("F2");
            }
        }
        public DateTime Fecha { get => dtpFechaDonacion.Value; set => dtpFechaDonacion.Value = value; }
        public frmAgregarDonaciones() => InitializeComponent();


        private void btnAceptar_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //TODA ESTA PARTE ES PARA VALIDAR DATOS EN EL FORMULARIO
        private void frmAgregarDonaciones_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;

            txtID.Focus();
            txtDonante.TextChanged += ValidarFormulario;
            txtEmail.TextChanged += ValidarFormulario;
            txtMonto.TextChanged += ValidarFormulario;
            mtxTelefono.TextChanged += ValidarFormulario;
            dtpFechaDonacion.ValueChanged += ValidarFormulario;

        }

        public void ValidarFormulario(object? sender, EventArgs e)
        {
            bool idOk = !string.IsNullOrWhiteSpace(txtDonante.Text);
            bool donanteOK = !string.IsNullOrWhiteSpace(txtDonante.Text);
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool emailOK = !string.IsNullOrWhiteSpace(txtEmail.Text) && Regex.IsMatch(txtEmail.Text, patronCorreo);
            bool montoOK = !string.IsNullOrWhiteSpace(txtMonto.Text);
            bool telefonoOk = mtxTelefono.MaskFull && mtxTelefono.Text.Length == 9;
            bool fechaOk = dtpFechaDonacion.Value >= DateTime.Today;

            errorProvider1.SetError(txtDonante, donanteOK ? "" : "El nombre es obligatorio.");
            errorProvider1.SetError(txtEmail, emailOK ? "" : "El correo no es válido.");
            errorProvider1.SetError(txtMonto, montoOK ? "" : "El monto es obligatorio.");
            errorProvider1.SetError(mtxTelefono, telefonoOk ? "" : "El teléfono no es válido.");
            errorProvider1.SetError(dtpFechaDonacion, fechaOk ? "" : "La fecha no puede ser futura.");

            btnAceptar.Enabled = idOk && donanteOK && emailOK && montoOK && telefonoOk && fechaOk;
        }

        private void mtxTelefono_Click(object sender, EventArgs e)
        {
            mtxTelefono.SelectionStart = 0;
        }

        private void txtDonante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar == '.' && !txtMonto.Text.Contains('.'))
                return;
            e.Handled = true;
        }
    }
}
