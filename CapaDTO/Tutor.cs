using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Tutor
    {
        private int id;
        private string rut;
        private string nombre;
        private string apellido;
        private string correo;
        private string telefono;
        private string clave;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
