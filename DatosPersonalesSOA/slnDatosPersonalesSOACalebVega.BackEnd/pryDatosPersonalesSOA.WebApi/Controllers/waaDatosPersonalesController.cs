using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using pryDatosPersonalesSOA.Model;
using pryDatosPersonalesSOA.BusinessRule;

namespace pryDatosPersonalesSOA.WebApi.Controllers
{
    public class waaDatosPersonalesController : ApiController
    {
        // GET: api/waaDatosPersonales
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/waaDatosPersonales/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/waaDatosPersonales
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/waaDatosPersonales/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/waaDatosPersonales/5
        public void Delete(int id)
        {
        }
        [HttpPost]
        [Route("fncDatosPersonales")]
        public mdlDatosPersonales fncDatosPersonales(mdlDatosPersonales objmdlDatosPersonales)
        {
            itfDatosPersonales objItfDatosPersonales = new clsDatosPersonales();
            objmdlDatosPersonales = objItfDatosPersonales.fncDatosPersonales(objmdlDatosPersonales);
            return objmdlDatosPersonales;

        }
    }
}
