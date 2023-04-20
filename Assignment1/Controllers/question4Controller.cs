using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class question4Controller : ApiController
    {
        /// <summary>
        /// Returns the string "Greetings to {id} people!" where id is an integer value.
        /// </summary>
        /// <param name="id">The integer input.</param>
        /// <returns>The greeting string with the number of people.</returns>
        [HttpGet]
        [Route("api/Greeting/{id}")]
        public IHttpActionResult GetGreeting(int id)
        {
            string result = $"Greetings to {id} people!";
            return Ok(result);
        }
    }
}
