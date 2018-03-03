using GAP.Procesos.Model.Context;
using GAP.Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Procesos.Model.Dao
{
    internal class TipoCubrimientosDao
    {
        internal List<TipoCubrimiento> ObtenerTipoCubrimientos()
        {
            using (SegurosContext con = new SegurosContext())
            {
                return con.TipoCubrimiento.ToList();
            }
        }
    }
}
