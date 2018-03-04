﻿using GAP.Seguros.Api.Filters;
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
        [Route("api/Polizas/CancelarPolizas")]
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
        [Route("api/Polizas/GuardarPoliza")]
        [ValidateModel]
        public HttpResponseMessage GuardarPoliza([FromBody]Poliza poliza)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    this._repository.GuardarPoliza(poliza);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

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
