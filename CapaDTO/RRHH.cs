using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class RRHH
    {
        private int id;
        private string rut;
        private string clave;
        private string nombre;
        private string apellido;
        private string fecha_nac;
        private string telefono;
        private string correo;
        private int cargo_id;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Cargo_id { get => cargo_id; set => cargo_id = value; }
    }
}
