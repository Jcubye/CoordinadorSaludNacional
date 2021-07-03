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
    public class NegocioPaciente
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }
        public void insertarPaciente(Paciente paciente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.paciente (rut,clave,nombre,apellido,fecha_nac,telefono,correo,cargo_id) VALUES ('" + paciente.Rut +
                                    "','" + paciente.Nombre +
                                    "','" + paciente.Apellido +
                                    "','" + paciente.Apellido +
                                    "','" + paciente.Fecha_nac +
                                    "','" + paciente.Genero +
                                    "','" + paciente.Direccion +
                                    "','" + paciente.Comuna +
                                    "','" + paciente.Region +
                                    "','" + paciente.Telefono +
                                    "','" + paciente.Antecedentes +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public void actualizarPaciente(Paciente paciente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.rrhh SET rut = '" + paciente.Rut +
                ", nombre = '" + paciente.Nombre +
                ", apellido = '" + paciente.Apellido +
                ", fecha_nacimiento = '" + paciente.Fecha_nac +
                ", genero = '" + paciente.Genero +
                ", direccion = '" + paciente.Telefono +
                ", comuna = '" + paciente.Comuna +
                ", region = '" + paciente.Region +
                ", telefono = '" + paciente.Telefono +
                ", antecedentes = '" + paciente.Antecedentes +
                ", tuto_id = '" + paciente.Id_tutor +
                "' WHERE rut = '" + paciente.Rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
        public void eliminarPaciente(String rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.paciente WHERE rut = '" +
                rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        public DataSet consultaPaciente()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "pacoemte";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.paciente;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public Paciente buscaPaciente(String rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "paciente";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.paciente WHERE rut = '" +
                                    rut + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Paciente auxPaciente = new Paciente();
            try
            {
                auxPaciente.Id = (int)dt.Rows[0]["id"];
                auxPaciente.Rut = (String)dt.Rows[0]["rut"];
                auxPaciente.Nombre = (String)dt.Rows[0]["nombre"];
                auxPaciente.Apellido = (String)dt.Rows[0]["apellido"];
                auxPaciente.Fecha_nac = (String)dt.Rows[0]["fecha_nacimiento"];
                auxPaciente.Genero = (String)dt.Rows[0]["genero"];
                auxPaciente.Direccion = (String)dt.Rows[0]["direccion"];
                auxPaciente.Comuna = (String)dt.Rows[0]["comuna"];
                auxPaciente.Region = (String)dt.Rows[0]["region"];
                auxPaciente.Telefono = (String)dt.Rows[0]["telefono"];
                auxPaciente.Antecedentes = (String)dt.Rows[0]["antecedentes"];
                auxPaciente.Id_tutor = (int)dt.Rows[0]["tutor_id"];
            }
            catch (Exception ex)
            {
                auxPaciente.Id = 0;
                auxPaciente.Rut = String.Empty;
                auxPaciente.Nombre = String.Empty; ;
                auxPaciente.Apellido = String.Empty; ;
                auxPaciente.Fecha_nac = String.Empty; ;
                auxPaciente.Genero = String.Empty; ;
                auxPaciente.Direccion = String.Empty; ;
                auxPaciente.Comuna = String.Empty; ;
                auxPaciente.Region = String.Empty; ;
                auxPaciente.Telefono = String.Empty; ;
                auxPaciente.Antecedentes = String.Empty; ;
                auxPaciente.Id_tutor = 0;
            }

            return auxPaciente;
        }


        public Paciente posicionPaciente(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.paciente ;";
            this.Conec.NombreTabla = "paciente";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Paciente auxPaciente = new Paciente();
            try
            {
                auxPaciente.Id = (int)dt.Rows[0]["id"];
                auxPaciente.Rut = (String)dt.Rows[0]["rut"];
                auxPaciente.Nombre = (String)dt.Rows[0]["nombre"];
                auxPaciente.Apellido = (String)dt.Rows[0]["apellido"];
                auxPaciente.Fecha_nac = (String)dt.Rows[0]["fecha_nacimiento"];
                auxPaciente.Genero = (String)dt.Rows[0]["genero"];
                auxPaciente.Direccion = (String)dt.Rows[0]["direccion"];
                auxPaciente.Comuna = (String)dt.Rows[0]["comuna"];
                auxPaciente.Region = (String)dt.Rows[0]["region"];
                auxPaciente.Telefono = (String)dt.Rows[0]["telefono"];
                auxPaciente.Antecedentes = (String)dt.Rows[0]["antecedentes"];
                auxPaciente.Id_tutor = (int)dt.Rows[0]["tutor_id"];
            }
            catch (Exception ex)
            {
                auxPaciente.Id = 0;
                auxPaciente.Rut = String.Empty;
                auxPaciente.Nombre = String.Empty; ;
                auxPaciente.Apellido = String.Empty; ;
                auxPaciente.Fecha_nac = String.Empty; ;
                auxPaciente.Genero = String.Empty; ;
                auxPaciente.Direccion = String.Empty; ;
                auxPaciente.Comuna = String.Empty; ;
                auxPaciente.Region = String.Empty; ;
                auxPaciente.Telefono = String.Empty; ;
                auxPaciente.Antecedentes = String.Empty; ;
                auxPaciente.Id_tutor = 0;
            }

            return auxPaciente;
        }
    }
}
