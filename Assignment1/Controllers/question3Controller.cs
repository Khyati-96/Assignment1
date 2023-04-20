using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class question3Controller : ApiController
    {
        /// <summary>
        /// Returns the string "Hello World!".
        /// </summary>
        /// <returns>The string "Hello World!"</returns>
        [HttpPost]
        [Route("api/Greeting")]
        public IHttpActionResult PostGreeting()
        {
            return Ok("Hello World!");
        }
    }
}
