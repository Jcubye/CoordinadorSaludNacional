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
    /// Summary description for ServicioTutor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioTutor : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarTutor(Tutor tutor)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.insertarTutor(tutor);

        }
        [WebMethod]
        public void actualizarTutor(Tutor tutor)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.actualizarTutor(tutor);

        }
        [WebMethod]
        public void eliminarTutor(String rut)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.eliminarTutor(rut);
        }

        [WebMethod]
        public DataSet consultarTutor()
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            return auxNegocio.consultarTutor();
        }

        [WebMethod]
        public Tutor buscaTutor(String rut)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            return auxNegocio.buscaTutor(rut);
        }

        [WebMethod]
        public Tutor posicionTutor(int fila)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            return auxNegocio.posicionTutor(fila); 
        }
    }
}
