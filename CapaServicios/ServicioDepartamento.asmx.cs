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
    /// Summary description for ServicioDepartamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioDepartamento : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarDepartamentoService(Departamento departamento)
        {
            NegocioDepartamento auxNegocio = new NegocioDepartamento();
            auxNegocio.insertarDepartamento(departamento);

        }
        [WebMethod]
        public void actualizarDepartamento(Departamento departamento)
        {
            NegocioDepartamento auxNegocio = new NegocioDepartamento();
            auxNegocio.actualizarDepartamento(departamento);

        }
        [WebMethod]
        public void eliminarDepartamento(int id)
        {
            NegocioDepartamento auxNegocio = new NegocioDepartamento();
            auxNegocio.eliminarDepartamento(id);
        }

        [WebMethod]
        public DataSet consultarDepartamento(int id)
        {
            NegocioDepartamento auxNegocio = new NegocioDepartamento();
            return auxNegocio.consultaDepartamento();
        }

        [WebMethod]
        public Departamento buscaDepartamento(int id)
        {
            NegocioDepartamento auxNegocio = new NegocioDepartamento();
            return auxNegocio.buscaDepartamento(id);
        }

        [WebMethod]
        public Departamento posicionDepartamento(int fila)
        {
            NegocioDepartamento auxNegocio = new NegocioDepartamento();
            return auxNegocio.buscaDepartamento(fila);
        }
    }
}
