using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaBackendNet.Controllers
{
    [Produces("application/json")]
    [Route("time")]
    public class TimeController : Controller
    {
        // GET: /time?value={hh:mm}
        [HttpGet]
        public string Get([FromQuery]string value)
        {
         
            DateTime loadedDate = DateTime.Parse(value);
            string datelocal= loadedDate.ToString("yyyy-MM-ddTHH:mm:ssZ");
            return datelocal;
      
        }
        
    
        // POST: time
        [HttpPost]
        public void Post()
        {
        }
    }
}
