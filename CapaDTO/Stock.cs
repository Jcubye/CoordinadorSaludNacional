using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Stock
    {
        private int id;
        private int hospitalizacion_id;
        private int articulo_id;

        public int Id { get => id; set => id = value; }
        public int Hospitalizacion_id { get => hospitalizacion_id; set => hospitalizacion_id = value; }
        public int Articulo_id { get => articulo_id; set => articulo_id = value; }
    }
}
