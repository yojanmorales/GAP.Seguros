using GAP.Procesos.Model.Context;
using GAP.Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Procesos.Model.Dao
{
    internal class ClientesDao
    {
        internal List<Cliente> ObtenerClientes()
        {
            using (SegurosContext con = new SegurosContext())
            {
                return con.Cliente.ToList();
            }
        }


        internal Cliente ObtenerClientePorId(int clienteId)
        {
            using (SegurosContext con = new SegurosContext())
            {
                return con.Cliente.FirstOrDefault(p => p.Id == clienteId);
            }
        }
    }
}
