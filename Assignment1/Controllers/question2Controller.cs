using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class question2Controller : ApiController
    {
        /// <summary>
        /// Returns the square of the integer input {id}.
        /// </summary>
        /// <param name="id">The integer input.</param>
        /// <returns>The square of the integer input.</returns>
        [HttpGet]
        [Route("api/Square/{id}")]
        public IHttpActionResult GetSquare(int id)
        {
            int result = id * id;
            return Ok(result);
        }
    }
}
