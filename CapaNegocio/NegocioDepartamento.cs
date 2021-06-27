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
    public class NegocioDepartamento
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarDepartamento(Departamento departamento)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.departamento (nombre) VALUES ('" + departamento.Nombre + "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void actualizarDepartamento(Departamento departamento)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.departamento SET nombre = '"+
                departamento.Nombre + "' WHERE id = '" +
                departamento.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarDepartamento(int id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.departamento WHERE id = '" +
                id +"';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultaDepartamento()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "departamento";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.departamento;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public Departamento buscaDepartamento(int id)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "departamento";   
            this.Conec.CadenaSQL = "SELECT * FROM dbo.departamento WHERE id = '" +
                                    id + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Departamento auxDepartamento = new Departamento();
            try
            {
                auxDepartamento.Id = (int)dt.Rows[0]["id"];
                auxDepartamento.Nombre = (String)dt.Rows[0]["nombre"];
            }
            catch (Exception ex)
            {
                auxDepartamento.Id = 0;
                auxDepartamento.Nombre = String.Empty;
            }

            return auxDepartamento;
        }

        public Departamento posicionDepartamento(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.departamento ;";
            this.Conec.NombreTabla = "departamento";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Departamento auxDepartamento = new Departamento();
            try
            {
                auxDepartamento.Id = (int)dt.Rows[fila]["id"];
                auxDepartamento.Nombre = (String)dt.Rows[fila]["nombre"];
            }
            catch (Exception ex)
            {
                auxDepartamento.Id = 0;
                auxDepartamento.Nombre = String.Empty;
            }

            return auxDepartamento;
        }
    }
}
