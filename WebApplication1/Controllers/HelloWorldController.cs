using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : ApiController
    {
        // GET: HelloWorld
        [HttpGet]
        public String Index()
        {
            return "Hello World!";
        }
    }
}