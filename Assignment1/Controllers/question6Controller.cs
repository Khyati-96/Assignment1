using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class question6Controller : ApiController
    {
        /// <summary>
        /// Calculates the total hosting cost based on the number of days elapsed since the beginning of hosting.
        /// </summary>
        /// <param name="id">The number of days elapsed.</param>
        /// <returns>The total hosting cost with breakdown.</returns>
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public IHttpActionResult GetHostingCost(int id)
        {
            double fortnights = Math.Ceiling((double)id / 14);
            double costPerFortnight = 5.50;
            double hstRate = 0.13;
            double hstAmount = fortnights * costPerFortnight * hstRate;
            double totalCost = fortnights * costPerFortnight + hstAmount;

            string result = string.Format("Fortnights: {0} at ${1}/FN = ${2} CAD", fortnights, costPerFortnight, fortnights * costPerFortnight);
            result += string.Format("\nHST 13% = ${0} CAD", hstAmount);
            result += string.Format("\nTotal = ${0} CAD", totalCost);

            return Ok(result);
        }
    }
}
