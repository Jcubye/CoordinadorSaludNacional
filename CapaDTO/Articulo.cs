using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Articulo
    {
        private int id;
        private string producto;
        private int cantidad;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
