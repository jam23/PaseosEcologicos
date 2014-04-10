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
    public class AlojamientosController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        private Factory factory = new Factory();

        // GET api/alojamientos
        public HttpResponseMessage Get()
        {
            //var alojamientos = uow.Servicios.GetAll().Where(s => s.TipoId == 1);
            var alojamientos = new List<Alojamiento>() { 
                new Alojamiento{
                    Id = 1,
                    Titulo = "Cabaña"
                },
                new Alojamiento{
                    Id = 2,
                    Titulo = "Playa"
                },
                new Alojamiento{
                    Id = 3,
                    Titulo = "Hotel"
                }
            };

            return Request.CreateResponse(HttpStatusCode.OK, alojamientos);
        }

        // GET api/alojamientos/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/alojamientos
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/alojamientos/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/alojamientos/5
        //public void Delete(int id)
        //{
        //}
    }
}
