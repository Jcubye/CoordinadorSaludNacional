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
    /// Summary description for ServiceEspecialidad
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceEspecialidad : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarEspecialidad(Especialidad especialidad)
        {
            NegocioEspecialidad auxNegocio = new NegocioEspecialidad();
            auxNegocio.insertarEspecialidad(especialidad);

        }
        [WebMethod]
        public void actualizarEspecialidad(Especialidad especialidad)
        {
            NegocioEspecialidad auxNegocio = new NegocioEspecialidad();
            auxNegocio.actualizarEspecialidad(especialidad);

        }
        [WebMethod]
        public void eliminarEspecialidad(int id)
        {
            NegocioEspecialidad auxNegocio = new NegocioEspecialidad();
            auxNegocio.eliminarEspecialidad(id);
        }

        [WebMethod]
        public DataSet consultaEspecialidad()
        {
            NegocioEspecialidad auxNegocio = new NegocioEspecialidad();
            return auxNegocio.consultaEspecialidad();
        }

        [WebMethod]
        public Especialidad buscaEspecialidad(int id)
        {
            NegocioEspecialidad auxNegocio = new NegocioEspecialidad();
            return auxNegocio.buscaEspecialidad(id);
        }

        [WebMethod]
        public Especialidad posicionTutor(int fila)
        {
            NegocioEspecialidad auxNegocio = new NegocioEspecialidad();
            return auxNegocio.posicionEspecialidad(fila);
        }
    }
}
