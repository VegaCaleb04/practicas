using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pryDatosPersonalesCalebVega.Model;

namespace pryDatosPersonalesCalebVega.BusinessRule
{
    public interface itfDatosPersonales
    {
        mdlDatosPersonales fncDatosPersonales(mdlDatosPersonales objDatosPersonales);
    }
}
