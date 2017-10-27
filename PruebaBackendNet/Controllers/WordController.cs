using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaBackendNet.Controllers
{
    [Produces("application/json")]
    [Route("word")]
    public class WordController : Controller
    {
        // GET: /word
        [HttpGet]
        public void Get()
        {
        }

        // POST: /word
        [HttpPost]
        public string Post([FromBody]string data)
        {
            if (data.Length == 4)
            {
                int temp;
                if (!(int.TryParse(data, out temp)))
                {
                    string upperString = data.ToUpper();
                    return upperString;
                }
                else
                {
                    return "Entrada no valida";
                }
            }
            else
            {
                return "Entrada no valida";
            }
        }
    }     
}
