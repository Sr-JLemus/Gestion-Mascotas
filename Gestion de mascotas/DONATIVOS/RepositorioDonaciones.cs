using Bogus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_mascotas.DONATIVOS
{
    public class RepositorioDonaciones
    {
        public BindingList<Donaciones> Donaciones { get; private set; }

        public RepositorioDonaciones()
        {
            Donaciones = new BindingList<Donaciones>();
        }

        public void GenerarDonaciones(int donacion)
        {
            string[] donante = { "Juan Perez", "Maria Gomez", "Carlos Ruiz", "Ana Torres", "Luis Fernandez" };
            string[] telefono = { "7555-1234", "7655-5678", "7455-8765", "7985-4321", "6555-6789" };
            string[] email = { "juan@gmail.com", "maria@gmail.com", "carlos@gmail.com", "ana.torres2@catolica.edu.sv", "luis@gmail.com" };
            string[] monto = { "100.00", "250.00", "500.00", "750.00", "1000.00" };
            string[] fecha = { "01/01/2023", "15/02/2023", "10/03/2023", "25/04/2023", "30/05/2023" };

            var faker = new Faker("es");
            for (int i = 0; i < donacion; i++)
            {
                Donaciones nuevaDonacion = new(
                    faker.Commerce.Ean8().Trim(),
                    faker.PickRandom(donante),
                    faker.PickRandom(telefono),
                    faker.PickRandom(email),
                    faker.Random.Decimal(1.0m, 1000.0m),
                    DateTime.Parse(faker.PickRandom(fecha))
                );
                Donaciones.Add(nuevaDonacion);
            }
        }

        public void Agregar(Donaciones donaciones) => Donaciones.Add(donaciones);
        public void Eliminar(Donaciones donaciones) => Donaciones.Remove(donaciones);
        public void Modificar(int index, Donaciones donaciones) => Donaciones[index] = donaciones;
        public bool ExisteCodigo(string id) => Donaciones.Any(d => d.ID.Equals(id, StringComparison.OrdinalIgnoreCase));
    }
}
