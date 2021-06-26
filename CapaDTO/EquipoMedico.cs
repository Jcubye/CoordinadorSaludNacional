using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    class EquipoMedico
    {
        private int id;
        private string responsable;
        private string fecha_conformacion;
        private int cantidad_personal;
        private string detalle_personal;
        private int rrhh_id;
        private int hospitalizacion_id;
        private int epicrisis_id;

        public int Id { get => id; set => id = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public string Fecha_conformacion { get => fecha_conformacion; set => fecha_conformacion = value; }
        public int Cantidad_personal { get => cantidad_personal; set => cantidad_personal = value; }
        public string Detalle_personal { get => detalle_personal; set => detalle_personal = value; }
        public int Rrhh_id { get => rrhh_id; set => rrhh_id = value; }
        public int Hospitalizacion_id { get => hospitalizacion_id; set => hospitalizacion_id = value; }
        public int Epicrisis_id { get => epicrisis_id; set => epicrisis_id = value; }
    }
}
