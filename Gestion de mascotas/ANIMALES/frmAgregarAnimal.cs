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
            get => rdbLibre.Checked ? "Libre" : "Adoptado";
            set
            {
                if (value == "Libre")
                    rdbLibre.Checked = true;
                else if (value == "Adoptado")
                    rdbAdoptado.Checked = true;
            }
        }
        public frmAgregarAnimal() => InitializeComponent();

        private void btnAgregarA_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
       

        private void btnCancelarAnimal_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
    



}
}
