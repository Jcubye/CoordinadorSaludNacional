using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cargo
    {
        private int id;
        private string nombre;
        private string fecha_inicio;
        private string descripcion;
        private string estado;
        private int id_departamento;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_departamento { get => id_departamento; set => id_departamento = value; }
    }
}
