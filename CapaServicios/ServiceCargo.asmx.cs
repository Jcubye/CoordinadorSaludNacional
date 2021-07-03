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
    /// Summary description for ServiceCargo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceCargo : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarCargo(Cargo cargo)
        {
            NegocioCargo auxNegocio = new NegocioCargo();
            auxNegocio.insertarCargo(cargo);

        }
        [WebMethod]
        public void actualizarCargo(Cargo cargo)
        {
            NegocioCargo auxNegocio = new NegocioCargo();
            auxNegocio.actualizarCargo(cargo);

        }
        [WebMethod]
        public void eliminarCargo(int id)
        {
            NegocioCargo auxNegocio = new NegocioCargo();
            auxNegocio.eliminarCargo(id);
        }

        [WebMethod]
        public DataSet consultaCargo()
        {
            NegocioCargo auxNegocio = new NegocioCargo();
            return auxNegocio.consultaCargo();
        }

        [WebMethod]
        public Cargo buscaCargo(int id)
        {
            NegocioCargo auxNegocio = new NegocioCargo();
            return auxNegocio.buscaCargo(id);
        }

        [WebMethod]
        public Cargo posicionCargo(int fila)
        {
            NegocioCargo auxNegocio = new NegocioCargo();
            return auxNegocio.posicionCargo(fila);
        }
    }
}
