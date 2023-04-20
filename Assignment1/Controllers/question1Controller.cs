using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class question1Controller : ApiController
    {
        /// <summary>
        /// Returns 10 more than the integer input {id}.
        /// </summary>
        /// <param name="id">The integer input.</param>
        /// <returns>10 more than the integer input.</returns>
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public IHttpActionResult GetAddTen(int id)
        {
            int result = id + 10;
            return Ok(result);
        }
    }
}
