using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pryDatosPersonalesSOA.Model;

namespace pryDatosPersonalesSOA.BusinessRule
{
    public class clsDatosPersonales: itfDatosPersonales
    {
        public clsDatosPersonales()
        {

        }
        public mdlDatosPersonales fncDatosPersonales(mdlDatosPersonales objmdlDatosPersonales ) {
            return objmdlDatosPersonales;

        }
    }

}
