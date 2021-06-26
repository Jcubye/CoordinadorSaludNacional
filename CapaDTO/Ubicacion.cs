using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    class Ubicacion
    {
        private int id;
        private int sala;
        private int cama;
        private string area;
        private string edificio;

        public int Id { get => id; set => id = value; }
        public int Sala { get => sala; set => sala = value; }
        public int Cama { get => cama; set => cama = value; }
        public string Area { get => area; set => area = value; }
        public string Edificio { get => edificio; set => edificio = value; }
    }
}
