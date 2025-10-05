using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_mascotas.DONATIVOS
{
    public struct Donaciones
    {
        public string ID;
        public string Donante;
        public string Telefono;
        public string Email;
        public decimal Monto;
        public DateTime Fecha;

        public Donaciones(string id, string donante, string telefono, string email, decimal monto, DateTime fecha) : this()
        {
            this.ID = id;
            this.Donante = donante;
            this.Telefono = telefono;
            this.Email = email;
            this.Monto = monto;
            this.Fecha = fecha;
        }
    }
}
