using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    class Videollamada
    {
        private int id;
        private string disponibilidad;
        private string fecha;
        private string descripcion;
        private int id_paciente;

        public int Id { get => id; set => id = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_paciente { get => id_paciente; set => id_paciente = value; }
    }
}
