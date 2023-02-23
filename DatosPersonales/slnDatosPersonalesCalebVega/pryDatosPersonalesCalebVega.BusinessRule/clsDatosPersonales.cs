using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pryDatosPersonalesCalebVega.Model;

namespace pryDatosPersonalesCalebVega.BusinessRule
{
    public class clsDatosPersonales:  itfDatosPersonales
    {
        public mdlDatosPersonales fncDatosPersonales(mdlDatosPersonales objDatosPersonales)
        {
            objDatosPersonales.retorno = objDatosPersonales.nombre + " " + objDatosPersonales.apellido + " " + objDatosPersonales.documento;
            return objDatosPersonales;
       }
    }
}
