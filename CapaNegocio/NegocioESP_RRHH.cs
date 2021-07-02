using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class NegocioESP_RRHH
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void instertarESP_RRHH(ESP_RRHH esp_rrhh)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.esp_rrhh (rrhh_id,especialidad_id) VALUES ('" + esp_rrhh.Rrhh_id +
                                    "','" + esp_rrhh.Especialidad_id +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
    }
}
