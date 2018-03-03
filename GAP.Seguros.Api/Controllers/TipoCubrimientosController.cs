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
    public class TipoCubrimientosController : ApiController
    {
        readonly TipoCubrimientosFacade _repository;

        public TipoCubrimientosController()

        {
            _repository = new TipoCubrimientosFacade();
        }

        // GET api/TipoCubrimiento
        [HttpGet]
        public IHttpActionResult ObtenerTipoCubrimientos()
        {
            var tiposCubrimientos = _repository.ObtenerTipoCubrimientos();
            return Ok(tiposCubrimientos);
        }
    }
}
