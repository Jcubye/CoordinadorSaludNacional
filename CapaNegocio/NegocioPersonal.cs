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
    class NegocioPersonal
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarPersonal(RRHH rrhh)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.rrhh (rut,clave,nombre,apellido,fecha_nac,telefono,correo,cargo_id) VALUES ('" + rrhh.Rut +
                                    "','" + rrhh.Clave +
                                    "','" + rrhh.Nombre +
                                    "','" + rrhh.Apellido +
                                    "','" + rrhh.Fecha_nac +
                                    "','" + rrhh.Telefono +
                                    "','" + rrhh.Correo +
                                    "','" + rrhh.Cargo_id +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public void actualizarPersonal(RRHH rrhh)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.rrhh SET rut = '" + rrhh.Rut +
                ", clave = '" + rrhh.Clave +
                ", nombre = '" + rrhh.Nombre +
                ", apellido = '" + rrhh.Apellido +
                ", fecha_nac = '" + rrhh.Fecha_nac +
                ", telefono = '" + rrhh.Telefono +
                ", correo = '" + rrhh.Correo +
                ", cargo_id = '" + rrhh.Cargo_id +
                "' WHERE rut = '" + rrhh.Rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarPersonal(String rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.rrhh WHERE rut = '" +
                rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultarPersonal()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "rrhh";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.rrhh;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public RRHH buscaPersonal(String rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "rrhh";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.rrhh WHERE rut = '" +
                                    rut + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            RRHH auxPersonal = new RRHH();
            try
            {
                auxPersonal.Id = (int)dt.Rows[0]["id"];
                auxPersonal.Rut = (String)dt.Rows[0]["rut"];
                auxPersonal.Clave = (String)dt.Rows[0]["clave"];
                auxPersonal.Nombre = (String)dt.Rows[0]["nombre"];
                auxPersonal.Apellido = (String)dt.Rows[0]["apellido"];
                auxPersonal.Fecha_nac = (String)dt.Rows[0]["fecha_nac"];
                auxPersonal.Telefono = (String)dt.Rows[0]["telefono"];
                auxPersonal.Correo = (String)dt.Rows[0]["correo"];
                auxPersonal.Cargo_id = (int)dt.Rows[0]["cargo_id"];
            }
            catch (Exception ex)
            {
                auxPersonal.Id = 0;
                auxPersonal.Rut = String.Empty;
                auxPersonal.Clave = String.Empty;
                auxPersonal.Nombre = String.Empty;
                auxPersonal.Apellido = String.Empty;
                auxPersonal.Fecha_nac = String.Empty;
                auxPersonal.Telefono = String.Empty;
                auxPersonal.Correo = String.Empty;
                auxPersonal.Cargo_id = 0;
            }

            return auxPersonal;
        }


        public RRHH posicionPersonal(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.rrhh ;";
            this.Conec.NombreTabla = "rrhh";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            RRHH auxPersonal = new RRHH();
            try
            {
                auxPersonal.Id = (int)dt.Rows[fila]["id"];
                auxPersonal.Rut = (String)dt.Rows[fila]["rut"];
                auxPersonal.Clave = (String)dt.Rows[fila]["clave"];
                auxPersonal.Nombre = (String)dt.Rows[fila]["nombre"];
                auxPersonal.Apellido = (String)dt.Rows[fila]["apellido"];
                auxPersonal.Fecha_nac = (String)dt.Rows[fila]["fecha_nac"];
                auxPersonal.Telefono = (String)dt.Rows[fila]["telefono"];
                auxPersonal.Correo = (String)dt.Rows[fila]["correo"];
                auxPersonal.Cargo_id = (int)dt.Rows[fila]["cargo_id"];
            }
            catch (Exception ex)
            {
                auxPersonal.Id = 0;
                auxPersonal.Rut = String.Empty;
                auxPersonal.Clave = String.Empty;
                auxPersonal.Nombre = String.Empty;
                auxPersonal.Apellido = String.Empty;
                auxPersonal.Fecha_nac = String.Empty;
                auxPersonal.Telefono = String.Empty;
                auxPersonal.Correo = String.Empty;
                auxPersonal.Cargo_id = 0;
            }

            return auxPersonal;
        }
    }
}
