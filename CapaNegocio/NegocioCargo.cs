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
    public class NegocioCargo
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarCargo(Cargo cargo)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.cargo (nombre,fecha_inicio,descripcion,estado,departamento_id) VALUES ('" + cargo.Nombre +
                                    "','" + cargo.Fecha_inicio +
                                    "','" + cargo.Descripcion +
                                    "','" + cargo.Estado +
                                    "','" + cargo.Id_departamento +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public void actualizarCargo(Cargo cargo)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.cargo SET id = '" + cargo.Id +
                ", nombre = '" + cargo.Nombre +
                ", fecha_inicio = '" + cargo.Fecha_inicio +
                ", descripcion = '" + cargo.Descripcion +
                ", estado = '" + cargo.Estado +
                ", departamento_id = '" + cargo.Id_departamento +

                "' WHERE id = '" + cargo.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarCargo(int id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.cargo WHERE id = '" +
                id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultaCargo()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "cargo";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.cargo;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public Cargo buscaCargo(int id)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "cargo";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.cargo WHERE id = '" +
                                    id + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Cargo auxCargo = new Cargo();
            try
            {
                auxCargo.Id = (int)dt.Rows[0]["id"];
                auxCargo.Nombre = (String)dt.Rows[0]["rut"];
                auxCargo.Fecha_inicio = (String)dt.Rows[0]["nombre"];
                auxCargo.Descripcion = (String)dt.Rows[0]["apellido"];
                auxCargo.Estado = (String)dt.Rows[0]["correo"];
                auxCargo.Id_departamento = (int)dt.Rows[0]["telefono"];
            }
            catch (Exception ex)
            {
                auxCargo.Id = 0;
                auxCargo.Nombre = String.Empty;
                auxCargo.Fecha_inicio = String.Empty;
                auxCargo.Descripcion = String.Empty;
                auxCargo.Estado = String.Empty;
                auxCargo.Id_departamento = 0;
            }

            return auxCargo;
        }


        public Cargo posicionCargo(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.cargo ;";
            this.Conec.NombreTabla = "cargo";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Cargo auxCargo = new Cargo();
            try
            {
                auxCargo.Id = (int)dt.Rows[fila]["id"];
                auxCargo.Nombre = (String)dt.Rows[fila]["rut"];
                auxCargo.Fecha_inicio = (String)dt.Rows[fila]["nombre"];
                auxCargo.Descripcion = (String)dt.Rows[fila]["apellido"];
                auxCargo.Estado = (String)dt.Rows[fila]["correo"];
                auxCargo.Id_departamento = 0;
            }
            catch (Exception ex)
            {
                auxCargo.Id = 0;
                auxCargo.Nombre = String.Empty;
                auxCargo.Fecha_inicio = String.Empty;
                auxCargo.Descripcion = String.Empty;
                auxCargo.Estado = String.Empty;
                auxCargo.Id_departamento = 0;
            }

            return auxCargo;
        }
    }
}
