using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for ServicePaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicePaciente : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarPaciente(Paciente paciente)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            auxNegocio.insertarPaciente(paciente);

        }
        [WebMethod]
        public void actualizarPaciente(Paciente paciente)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            auxNegocio.actualizarPaciente(paciente);

        }
        [WebMethod]
        public void eliminarPaciente(String rut)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            auxNegocio.eliminarPaciente(rut);
        }

        [WebMethod]
        public DataSet consultaPaciente()
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            return auxNegocio.consultaPaciente();
        }

        [WebMethod]
        public Paciente buscaPaciente(String rut)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            return auxNegocio.buscaPaciente(rut);
        }

        [WebMethod]
        public Paciente posicionPaciente(int fila)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            return auxNegocio.posicionPaciente(fila);
        }
    }
}
