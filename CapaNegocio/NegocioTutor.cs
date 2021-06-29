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
    public class NegocioTutor
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarTutor(Tutor tutor)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.tutor (rut,nombre,apellido,correo,telefono,clave) VALUES ('" + tutor.Rut + 
                                    "," + tutor.Nombre +
                                    "," + tutor.Apellido +
                                    "," + tutor.Correo +
                                    "," + tutor.Telefono +
                                    "," + tutor.Clave +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void actualizarTutor(Tutor tutor)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.tutor SET rut = '" + tutor.Rut + 
                ", nombre = '" + tutor.Nombre +
                ", apellido = '" + tutor.Apellido +
                ", correo = '" + tutor.Correo +
                ", telefono = '" + tutor.Telefono +
                ", clave = '" + tutor.Clave +

                "' WHERE rut = '" + tutor.Rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarTutor(String rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.tutor WHERE rut = '" +
                rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultarTutor()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "tutor";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.tutor;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public Tutor buscaTutor(String rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "tutor";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.tutor WHERE rut = '" +
                                    rut + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Tutor auxTutor = new Tutor();
            try
            {
                auxTutor.Id = (int)dt.Rows[0]["id"];
                auxTutor.Rut = (String)dt.Rows[0]["rut"];
                auxTutor.Nombre = (String)dt.Rows[0]["nombre"];
                auxTutor.Apellido = (String)dt.Rows[0]["apellido"];
                auxTutor.Correo = (String)dt.Rows[0]["correo"];
                auxTutor.Telefono = (String)dt.Rows[0]["telefono"];
                auxTutor.Clave = (String)dt.Rows[0]["clave"];
            }
            catch (Exception ex)
            {
                auxTutor.Id = 0;
                auxTutor.Rut = String.Empty;
                auxTutor.Nombre = String.Empty;
                auxTutor.Apellido = String.Empty;
                auxTutor.Correo = String.Empty;
                auxTutor.Telefono = String.Empty;
                auxTutor.Clave = String.Empty;
            }

            return auxTutor;
        }


        public Tutor posicionTutor(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.tutor ;";
            this.Conec.NombreTabla = "tutor";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Tutor auxTutor = new Tutor();
            try
            {
                auxTutor.Id = (int)dt.Rows[fila]["id"];
                auxTutor.Rut = (String)dt.Rows[fila]["rut"];
                auxTutor.Nombre = (String)dt.Rows[fila]["nombre"];
                auxTutor.Apellido = (String)dt.Rows[fila]["apellido"];
                auxTutor.Correo = (String)dt.Rows[fila]["correo"];
                auxTutor.Telefono = (String)dt.Rows[fila]["telefono"];
                auxTutor.Clave = (String)dt.Rows[fila]["clave"];
            }
            catch (Exception ex)
            {
                auxTutor.Id = 0;
                auxTutor.Rut = String.Empty;
                auxTutor.Nombre = String.Empty;
                auxTutor.Apellido = String.Empty;
                auxTutor.Correo = String.Empty;
                auxTutor.Telefono = String.Empty;
                auxTutor.Clave = String.Empty;
            }

            return auxTutor;
        }
    }
}
