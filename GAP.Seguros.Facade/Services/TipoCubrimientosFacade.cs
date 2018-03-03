using GAP.Procesos.Model.Repository.TipoCubrimientos;
using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Seguros.Facade.Services
{
    public class TipoCubrimientosFacade
    {
        private readonly ITipoCrubimientosRepository _ContextoRepositorio;
        public TipoCubrimientosFacade()
            : this(new TipoCrubimientosRepository())
        {
        }

        public TipoCubrimientosFacade(ITipoCrubimientosRepository contextoRepositorio)
        {
            this._ContextoRepositorio = contextoRepositorio;
        }

        /// <summary>
        /// Retorna todos los tipos cubrimientos
        /// </summary>
        /// <returns></returns>
        public List<TipoCubrimiento> ObtenerTipoCubrimientos()
        {
            return this._ContextoRepositorio.ObtenerTipoCubrimientos();
        }
    }
}
