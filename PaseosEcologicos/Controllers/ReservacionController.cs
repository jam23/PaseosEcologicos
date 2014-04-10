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
    public class ReservacionController : ApiController
    {
        private UnitOfWork uow = new UnitOfWork();
        private Factory factory = new Factory();

        // GET api/reservacion
        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, "");
        //}

        //// GET api/reservacion/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/reservacion
        public HttpResponseMessage Post([FromBody]Reservacion _reservacion)
        {
            try
            {
                var reservacion = factory.Create(_reservacion);
                var cliente = factory.Create(_reservacion.Cliente);
                uow.Clientes.Add(cliente);
                uow.Commit();
                reservacion.ClienteId = cliente.Id;
                uow.Reservaciones.Add(reservacion);
                uow.Commit();

                return Request.CreateResponse(HttpStatusCode.OK, "Reservacion creada");
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //// PUT api/reservacion/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/reservacion/5
        //public void Delete(int id)
        //{
        //}
    }
}
