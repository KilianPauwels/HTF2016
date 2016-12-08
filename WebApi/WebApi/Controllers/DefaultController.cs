using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("getData")]
        [HttpGet]
        public IHttpActionResult GetData()
        {
            return Ok();
        }

        
        [HttpPost]
        public IHttpActionResult PostData(DroneData dronedata)
        {
            
            return Ok();
        }

        [HttpOptions]
        public IHttpActionResult Options()
        {
            return Ok();
        }
    }
}
