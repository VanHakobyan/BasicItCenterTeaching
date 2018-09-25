using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        public IHttpActionResult Get()
        {
            return Ok("hi evrywhare");
        }

        // GET: api/Home/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.Accepted, "hi");
        }

        [HttpGet,Route("api/home/you")]
        public IHttpActionResult Me()
        {
            return Json("{}");
        }
        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
