using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using pryDatosPersonalesSOA.Model;
using pryDatosPersonalesSOA.BusinessRule;

namespace pryDatosPersonalesSOA.WebService
{
    /// <summary>
    /// Descripción breve de wsaDatosPersonales
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    // creamos una funcion que resibe unos parametros 
    public class wsaDatosPersonales : System.Web.Services.WebService
    {

        [WebMethod]
        public mdlDatosPersonales fncDatosPersonales( mdlDatosPersonales objmdlDatosPersonales)
        {
            itfDatosPersonales objItfDatosPersonales = new clsDatosPersonales();
         objmdlDatosPersonales=   objItfDatosPersonales.fncDatosPersonales(objmdlDatosPersonales);
            return objmdlDatosPersonales;
        
        }
    }
}
