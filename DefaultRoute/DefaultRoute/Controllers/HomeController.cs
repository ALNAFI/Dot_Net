using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DefaultRoute.Controllers
{
    public class HomeController : ApiController
    {
        public HttpResponseMessage Get() //https://localhost:44312/api/Home
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Get Method");
        }
        public HttpResponseMessage Post()// https://localhost:44312/api/Home
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Post Method");
        }
    }
}
