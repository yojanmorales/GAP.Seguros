using GAP.Procesos.Model.Dao;
using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.TipoCubrimientos
{
    public class TipoCrubimientosRepository : ITipoCrubimientosRepository
    {

        private readonly TipoCubrimientosDao _TipoCubrimientoDao;



        public TipoCrubimientosRepository()
        {
            _TipoCubrimientoDao = new TipoCubrimientosDao();
        }

        /// <summary>
        /// Retorna todos los tipos cubrimientos
        /// </summary>
        /// <returns></returns>
        public List<TipoCubrimiento> ObtenerTipoCubrimientos()
        {
            return _TipoCubrimientoDao.ObtenerTipoCubrimientos();
        }
    }
}
