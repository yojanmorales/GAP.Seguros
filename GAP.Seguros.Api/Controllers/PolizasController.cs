using GAP.Seguros.Entities;
using GAP.Seguros.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GAP.Seguros.Api.Controllers
{
    public class PolizasController : ApiController
    {

        readonly PolizasFacade _repository;

        public PolizasController()

        {
            _repository = new PolizasFacade();
        }



        // POST api/Poliza
        [HttpPost]
        public IHttpActionResult CancelarPolizas([FromBody]List<Poliza> polizas)
        {
            try
            {
                _repository.CancelarPolizas(polizas);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST api/Poliza
        [HttpPost]
        public IHttpActionResult GuardarPoliza([FromBody]Poliza poliza)
        {
            try
            {
                this._repository.GuardarPoliza(poliza);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET api/Polizas/2
        [HttpGet]
        public IHttpActionResult ObtenerPolizasPorCliente(int clienteId)
        {
            var polizas = this._repository.ObtenerPolizasPorCliente(clienteId);
            return Ok(polizas);
        }

    }
}
