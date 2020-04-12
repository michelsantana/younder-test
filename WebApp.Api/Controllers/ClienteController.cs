using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApp.Service.Interface;
using WebApp.Service.ViewModels;

namespace WebApp.Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ClienteController : ApiController
    {
        iClienteService _cliente;

        public ClienteController(iClienteService cliente)
        {
            _cliente = cliente;

        }

        // GET: api/Cliente
        public IEnumerable<ClienteVM> Get()
        {
            return _cliente.GetAll();
        }

        // GET: api/Cliente/5
        public ClienteVM Get(string id)
        {
            return _cliente.Get(id);
        }

        // POST: api/Cliente
        public ClienteVM Post([FromBody]ClienteVM cliente)
        {
            return _cliente.Add(cliente);
        }

        // PUT: api/Cliente/5
        public ClienteVM Put(string id, [FromBody]ClienteVM cliente)
        {
            cliente.id = id;
            return _cliente.Update(cliente);
        }

        // DELETE: api/Cliente/5
        public HttpResponseMessage Delete(string id)
        {
            _cliente.Remove(id);
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
    }
}
