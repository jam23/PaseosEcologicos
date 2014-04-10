using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PaseosEcologicos.Services;
using PaseosEcologicos.Services.DTOS;

namespace PaseosEcologicos.Controllers
{
    public class PaseosController : ApiController
    {

        UnitOfWork uow = new UnitOfWork();

        // GET api/paseos
        public HttpResponseMessage Get()
        {
            //var paseos = uow.Paseos.GetAll();
            var paseos = new string[] { "Los palmares", "Los haitises", "El cruce"};

            return Request.CreateResponse(HttpStatusCode.OK, paseos);
        }

        // GET api/paseos/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/paseos
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/paseos/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/paseos/5
        //public void Delete(int id)
        //{
        //}
    }
}
