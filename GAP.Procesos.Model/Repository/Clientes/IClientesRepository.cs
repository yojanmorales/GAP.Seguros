using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.Clientes
{
    interface IClientesRepository
    {

        IEnumerable<Cliente> ObtenerClientes();
        Cliente ObtenerClientePorId(int clienteId);
    }
}
