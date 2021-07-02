using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioEpicrisis
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarEpicrisis(Epicrisis epicrisis)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.epicrisis (fecha,detalle,diagnostico,tratamiento) VALUES ('" + epicrisis.Fecha +
                                    "','" + epicrisis.Detalle +
                                    "','" + epicrisis.Diagnostico +
                                    "','" + epicrisis.Tratamiento +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public void actualizarEpicrisis(Epicrisis epicrisis)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.epicrisis SET fecha = '" + epicrisis.Fecha +
                ", detalle = '" + epicrisis.Detalle +
                ", diagnostico = '" + epicrisis.Diagnostico +
                ", tratamiento = '" + epicrisis.Tratamiento +
                "' WHERE id = '" + epicrisis.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarEpicrisis(int id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.epicrisis WHERE id = '" +
                id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultaEpicrisis()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "epicrisis";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.epicrisis;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public Epicrisis buscaEpicrisis(int id)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "epicrisis";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.epicrisis WHERE id = '" +
                                    id + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Epicrisis auxEpicrisis = new Epicrisis();
            try
            {
                auxEpicrisis.Id = (int)dt.Rows[0]["id"];
                auxEpicrisis.Fecha = (String)dt.Rows[0]["rut"];
                auxEpicrisis.Detalle = (String)dt.Rows[0]["clave"];
                auxEpicrisis.Diagnostico = (String)dt.Rows[0]["nombre"];
                auxEpicrisis.Tratamiento = (String)dt.Rows[0]["apellido"];
            }
            catch (Exception ex)
            {
                auxEpicrisis.Id = 0;
                auxEpicrisis.Fecha = String.Empty;
                auxEpicrisis.Detalle = String.Empty;
                auxEpicrisis.Diagnostico = String.Empty;
                auxEpicrisis.Tratamiento = String.Empty;
            }

            return auxEpicrisis;
        }


        public Epicrisis posicionEpicrisis(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.epicrisis ;";
            this.Conec.NombreTabla = "epicrisis";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Epicrisis auxEpicrisis = new Epicrisis();
            try
            {
                auxEpicrisis.Id = (int)dt.Rows[0]["id"];
                auxEpicrisis.Fecha = (String)dt.Rows[0]["rut"];
                auxEpicrisis.Detalle = (String)dt.Rows[0]["clave"];
                auxEpicrisis.Diagnostico = (String)dt.Rows[0]["nombre"];
                auxEpicrisis.Tratamiento = (String)dt.Rows[0]["apellido"];
            }
            catch (Exception ex)
            {
                auxEpicrisis.Id = 0;
                auxEpicrisis.Fecha = String.Empty;
                auxEpicrisis.Detalle = String.Empty;
                auxEpicrisis.Diagnostico = String.Empty;
                auxEpicrisis.Tratamiento = String.Empty;
            }

            return auxEpicrisis;
        }
    }
}
