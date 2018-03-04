using GAP.Procesos.Model.Dao;
using GAP.Seguros.Entities;
using System;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.Polizas
{
    public class PolizasRepository : IPolizasRepository
    {


        private readonly PolizasDao _polizasDao;



        public PolizasRepository()
        {
            _polizasDao = new PolizasDao();
        }


        /// <summary>
        /// Cambia de estado las polizas a Cancelada
        /// </summary>
        /// <param name="polizas"></param>
        public void CancelarPolizas(Poliza poliza)
        {
            _polizasDao.CancelarPolizas(poliza);
        }

        /// <summary>
        /// Guarda la poliza
        /// </summary>
        /// <param name="poliza"></param>
        public void GuardarPoliza(Poliza poliza)
        {          
            _polizasDao.GuardarPoliza(poliza);
        }
        /// <summary>
        /// Obtiene las polizas por cliente
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns></returns>
        public List<Poliza> ObtenerPolizasPorCliente(int clienteId)
        {
            return _polizasDao.ObtenerPolizasPorCliente(clienteId);
        }
    }
}
