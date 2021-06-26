using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Epicrisis
    {
        private int id;
        private string fecha;
        private string detalle;
        private string diagnostico;
        private string tratamiento;

        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
    }
}
