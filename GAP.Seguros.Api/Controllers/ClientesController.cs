using GAP.Seguros.Entities;
using GAP.Seguros.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GAP.Seguros.Api.Controllers
{
   // [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClientesController : ApiController
    {

        readonly ClientesFacade _repository;

        public ClientesController()

        {
            _repository = new ClientesFacade();
        }


        // GET api/Clientes
        [HttpGet]
        public IHttpActionResult ObtenerClientes()
        {
            var clientes = _repository.ObtenerClientes();
            return Ok(clientes);
        }
        // GET api/Clientes/2
        [HttpGet]
        public IHttpActionResult ObtenerClientePorId(int clienteId)
        {
            var cliente = _repository.ObtenerClientePorId(clienteId);
            return Ok(cliente);
        }

    }
}
