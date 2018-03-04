using GAP.Procesos.Model.Context;
using GAP.Seguros.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GAP.Procesos.Model.Dao
{
    internal class PolizasDao
    {
        internal List<Poliza> ObtenerPolizasPorCliente(int clienteId)
        {
            using (SegurosContext con = new SegurosContext())
            {
                return con.Poliza.Where(p => p.ClienteId == clienteId && p.Estado == Seguros.Entities.Enums.EstadosEnum.Asignada).ToList();
            }
        }

        internal void GuardarPoliza(Poliza poliza)
        {
            using (SegurosContext con = new SegurosContext())
            {
                con.Poliza.Add(poliza);
                con.SaveChanges();
            }
        }

        internal void CancelarPolizas(Poliza poliza)
        {
            using (SegurosContext con = new SegurosContext())
            {

                poliza.Estado = Seguros.Entities.Enums.EstadosEnum.Cancelada;
                con.Entry(poliza).State = EntityState.Modified;


                con.SaveChanges();
            }
        }
    }
}
