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
    public class ComidasController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        private Factory factory = new Factory();

        // GET api/comidas
        public HttpResponseMessage Get()
        {
            var comidas = new List<Comida>() { 
                new Comida{
                    Id = 1,
                    Titulo = "Comida 1"
                },
                new Comida{
                    Id = 2,
                    Titulo = "Comida 1"
                },
                new Comida{
                    Id = 3,
                    Titulo = "Comida 1"
                },
            };

            return Request.CreateResponse(HttpStatusCode.OK, comidas);
        }

        // GET api/comidas/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/comidas
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/comidas/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/comidas/5
        //public void Delete(int id)
        //{
        //}
    }
}
