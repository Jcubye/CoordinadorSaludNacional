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
    /// Summary description for ServiceEpicrisis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceEpicrisis : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarEpicrisis(Epicrisis epicrisis)
        {
            NegocioEpicrisis auxNegocio = new NegocioEpicrisis();
            auxNegocio.insertarEpicrisis(epicrisis);

        }
        [WebMethod]
        public void actualizarEpicrisis(Epicrisis epicrisis)
        {
            NegocioEpicrisis auxNegocio = new NegocioEpicrisis();
            auxNegocio.actualizarEpicrisis(epicrisis);

        }
        [WebMethod]
        public void eliminarEpicrisis(int id)
        {
            NegocioEpicrisis auxNegocio = new NegocioEpicrisis();
            auxNegocio.eliminarEpicrisis(id);
        }

        [WebMethod]
        public DataSet consultaEpicrisis()
        {
            NegocioEpicrisis auxNegocio = new NegocioEpicrisis();
            return auxNegocio.consultaEpicrisis();
        }

        [WebMethod]
        public Epicrisis buscaEpicrisis(int id)
        {
            NegocioEpicrisis auxNegocio = new NegocioEpicrisis();
            return auxNegocio.buscaEpicrisis(id);
        }

        [WebMethod]
        public Epicrisis posicionEpicrisis(int fila)
        {
            NegocioEpicrisis auxNegocio = new NegocioEpicrisis();
            return auxNegocio.posicionEpicrisis(fila);
        }
    }
}
