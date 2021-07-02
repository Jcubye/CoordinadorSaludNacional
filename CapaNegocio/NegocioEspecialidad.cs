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
    public class NegocioEspecialidad
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarEspecialidad(Especialidad especialidad)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.especialidad (nombre) VALUES ('" + especialidad.Nombre + "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void actualizarEspecialidad(Especialidad especialidad)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.especialidad SET nombre = '" +
                especialidad.Nombre + "' WHERE id = '" +
                especialidad.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarEspecialidad(int id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.especialidad WHERE id = '" +
                id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultaEspecialidad()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "especialidad";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.especialidad;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public Especialidad buscaEspecialidad(int id)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "especialidad";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.especialidad WHERE id = '" +
                                    id + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Especialidad auxEspecialidad = new Especialidad();
            try
            {
                auxEspecialidad.Id = (int)dt.Rows[0]["id"];
                auxEspecialidad.Nombre = (String)dt.Rows[0]["nombre"];
            }
            catch (Exception ex)
            {
                auxEspecialidad.Id = 0;
                auxEspecialidad.Nombre = String.Empty;
            }

            return auxEspecialidad;
        }

        public Especialidad posicionEspecialidad(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.especialidad ;";
            this.Conec.NombreTabla = "especialidad";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Especialidad auxEspecialidad = new Especialidad();
            try
            {
                auxEspecialidad.Id = (int)dt.Rows[fila]["id"];
                auxEspecialidad.Nombre = (String)dt.Rows[fila]["nombre"];
            }
            catch (Exception ex)
            {
                auxEspecialidad.Id = 0;
                auxEspecialidad.Nombre = String.Empty;
            }

            return auxEspecialidad;
        }
    }
}
