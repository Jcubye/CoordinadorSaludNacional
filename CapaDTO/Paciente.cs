using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Paciente
    {
        private int id;
        private string rut;
        private string nombre;
        private string apellido;
        private string fecha_nac;
        private string genero;
        private string direccion;
        private string comuna;
        private string region;
        private string telefono;
        private string cantecedentes;
        private int id_tutor;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Comuna { get => comuna; set => comuna = value; }
        public string Region { get => region; set => region = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cantecedentes { get => cantecedentes; set => cantecedentes = value; }
        public int Id_tutor { get => id_tutor; set => id_tutor = value; }
    }
}
