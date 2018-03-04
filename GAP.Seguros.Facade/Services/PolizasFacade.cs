using GAP.Procesos.Model.Repository.Polizas;
using GAP.Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Seguros.Facade.Services
{
    public class PolizasFacade
    {

        private IPolizasRepository _ContextoRepositorio;
        public PolizasFacade()
            : this(new PolizasRepository())
        {
        }

        public PolizasFacade(IPolizasRepository contextoRepositorio)
        {
            this._ContextoRepositorio = contextoRepositorio;
        }



        /// <summary>
        /// Cambia de estado las polizas a Cancelada
        /// </summary>
        /// <param name="polizas"></param>
        public void CancelarPolizas(Poliza poliza)
        {
            this._ContextoRepositorio.CancelarPolizas(poliza);
        }

        /// <summary>
        /// Guarda la poliza
        /// </summary>
        /// <param name="poliza"></param>
        public void GuardarPoliza(Poliza poliza)
        {
            if (poliza.Cobertura > 50 && poliza.Riesgo == Seguros.Entities.Enums.RiesgosEnum.Alto)
            {
                throw new System.ArgumentNullException("El porcentaje de cubrimiento no puede ser mayor al 50% cuando el riesgo es alto.");

            }
            _ContextoRepositorio.GuardarPoliza(poliza);
        }
        /// <summary>
        /// Obtiene las polizas por cliente
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns></returns>
        public List<Poliza> ObtenerPolizasPorCliente(int clienteId)
        {
            return this._ContextoRepositorio.ObtenerPolizasPorCliente(clienteId);
        }

    }
}
