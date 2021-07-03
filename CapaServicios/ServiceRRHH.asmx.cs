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
    /// Summary description for ServiceRRHH
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceRRHH : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarPersonal(RRHH rrhh)
        {
            NegocioPersonal auxNegocio = new NegocioPersonal();
            auxNegocio.insertarPersonal(rrhh);

        }
        [WebMethod]
        public void actualizarPersonal(RRHH rrhh)
        {
            NegocioPersonal auxNegocio = new NegocioPersonal();
            auxNegocio.actualizarPersonal(rrhh);

        }
        [WebMethod]
        public void eliminarPersonal(String rut)
        {
            NegocioPersonal auxNegocio = new NegocioPersonal();
            auxNegocio.eliminarPersonal(rut);
        }

        [WebMethod]
        public DataSet consultarPersonal()
        {
            NegocioPersonal auxNegocio = new NegocioPersonal();
            return auxNegocio.consultarPersonal();
        }

        [WebMethod]
        public RRHH buscaPersonal(String rut)
        {
            NegocioPersonal auxNegocio = new NegocioPersonal();
            return auxNegocio.buscaPersonal(rut);

        }        
        [WebMethod]
        public RRHH posicionPersonal(int fila)
        {
            NegocioPersonal auxNegocio = new NegocioPersonal();
            return auxNegocio.posicionPersonal(fila);
        }
    }
}
