using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    class ESP_RRHH
    {
        private int id;
        private int rrhh_id;
        private int especialidad_id;

        public int Id { get => id; set => id = value; }
        public int Rrhh_id { get => rrhh_id; set => rrhh_id = value; }
        public int Especialidad_id { get => especialidad_id; set => especialidad_id = value; }
    }
}
