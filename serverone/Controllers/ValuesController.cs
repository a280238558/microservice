using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pivotal.Discovery.Client;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace serverone.Controllers
{
    [Route("/")]
    public class ValuesController : Controller
    {
      


        [HttpGet]
        public string Get()
        {
            return "order1";
          
        }

    }
}
