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
    public class DeportesController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        private Factory factory = new Factory();

        // GET api/deportes
        public HttpResponseMessage Get()
        {
            var deportes = new List<Deporte>() { 
                new Deporte{
                    Id = 1,
                    Titulo = "Deporte 1"
                },
                new Deporte{
                    Id = 2,
                    Titulo = "Deporte 1"
                },
                new Deporte{
                    Id = 3,
                    Titulo = "Deporte 1"
                },
            };

            return Request.CreateResponse(HttpStatusCode.OK, deportes);
        }

        //// GET api/deportes/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/deportes
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/deportes/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/deportes/5
        //public void Delete(int id)
        //{
        //}
    }
}
