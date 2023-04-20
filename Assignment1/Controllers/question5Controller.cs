using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class question5Controller : ApiController
    {
        /// <summary>
        /// Applies four mathematical operations to the input {id}.
        /// </summary>
        /// <param name="id">The integer input.</param>
        /// <returns>The result after applying four mathematical operations.</returns>
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public IHttpActionResult GetNumberMachine(int id)
        {
            int result = ((id + 5) * 2) / 3 - 7;
            return Ok(result);
        }
    }
}
