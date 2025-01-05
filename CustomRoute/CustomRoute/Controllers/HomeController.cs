using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomRoute.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("api/Scholaship")]
        public HttpResponseMessage Get1() //https://localhost:44370/api/Scholaship
        {  
            return Request.CreateResponse(HttpStatusCode.OK,"Scholaship"); 
        }
        [HttpGet]
        [Route("api/Probation")]
        public HttpResponseMessage Get2() //https://localhost:44370/api/Probation
        {
            return Request.CreateResponse(HttpStatusCode.OK,"Probation");
        }

    }
}
