using GAP.Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Procesos.Model.Repository.TipoCubrimientos
{
    public interface ITipoCrubimientosRepository
    {
        IEnumerable<TipoCubrimiento> ObtenerTipoCubrimientos();
    }
}
