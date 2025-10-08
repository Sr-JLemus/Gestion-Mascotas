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
    public partial class frmAgregarAnimal : Form

    {

        public string ID { get => txtIDAnimal.Text; set => txtIDAnimal.Text = value; }
        public string Nombre { get => txtNombreAnimal.Text; set => txtNombreAnimal.Text = value; }
        public string Especie { get => cmbEspecie.Text; set => cmbEspecie.Text = value; }
        public int Edad
        {
            get
            {
                int edad;
                if (int.TryParse(mtxEdadAnimal.Text, out edad))
                    return edad;
                return 0;
            }
            set
            {
                mtxEdadAnimal.Text = value.ToString();
            }
        }
        public string Sexo
        {
            get => rdbHembra.Checked ? "Hembra" : "Macho";
            set
            {
                if (value == "Hembra") rdbHembra.Checked = true;
                else rdbMacho.Checked = true;
            }
        }
        public string Estado
        {
            get => chkLibre.Checked ? "Libre" : "Adoptado";
            set
            {
                if (value == "Libre")
                    chkLibre.Checked = true;
                else if (value == "Adoptado")
                    chkAdoptado.Checked = true;
            }
        }





        public frmAgregarAnimal() => InitializeComponent();

        private void btnAgregarA_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;


        private void btnCancelarAnimal_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void frmAgregarAnimal_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;

            txtNombreAnimal.Focus();
            txtNombreAnimal.TextChanged += ValidarFormulario;
            cmbEspecie.TextChanged += ValidarFormulario;
            mtxEdadAnimal.TextChanged += ValidarFormulario;
            rdbHembra.CheckedChanged += ValidarFormulario;
            rdbMacho.CheckedChanged += ValidarFormulario;
            chkAdoptado.CheckedChanged += ValidarFormulario;
            chkLibre.CheckedChanged += ValidarFormulario;


        }

        private void ValidarFormulario(object? sender, EventArgs e)
        {
            bool nombreOk = !string.IsNullOrWhiteSpace(txtNombreAnimal.Text);
            bool especieOk = !string.IsNullOrWhiteSpace(cmbEspecie.Text);
            bool edadOk = mtxEdadAnimal.MaskFull && int.TryParse(mtxEdadAnimal.Text, out int edad) && edad >= 0;
            bool sexoOk = rdbHembra.Checked || rdbMacho.Checked;
            bool estadoOk = chkLibre.Checked || chkAdoptado.Checked;
            errorProvider1.SetError(txtNombreAnimal, nombreOk ? "" : "El nombre es obligatorio.");
            errorProvider1.SetError(cmbEspecie, especieOk ? "" : "La especie es obligatoria.");
            errorProvider1.SetError(mtxEdadAnimal, edadOk ? "" : "La edad no es válida.");
            errorProvider1.SetError(rdbHembra, sexoOk ? "" : "El sexo es obligatorio.");
            errorProvider1.SetError(chkLibre, estadoOk ? "" : "El estado es obligatorio.");
            btnAceptar.Enabled = nombreOk && especieOk && edadOk && sexoOk && estadoOk;
        }

        private void mtxEdadAnimal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxEdadAnimal.SelectionStart = 0;
        }

        private void txtNombreAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                return;

            e.Handled = true;
        }




    }
}

