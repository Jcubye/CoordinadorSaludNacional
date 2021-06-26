using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    class Hospitalizacion
    {
        private string id;
        private string fecha_ingreso;
        private string estado;
        private string fecha_alta;
        private string criticidad;
        private string detalles;
        private int paciente_id;
        private int ubicacion_id;

        public string Id { get => id; set => id = value; }
        public string Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public string Criticidad { get => criticidad; set => criticidad = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public int Paciente_id { get => paciente_id; set => paciente_id = value; }
        public int Ubicacion_id { get => ubicacion_id; set => ubicacion_id = value; }
    }
}
