using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.Clientes
{
    public interface IClientesRepository
    {

        List<Cliente> ObtenerClientes();
        Cliente ObtenerClientePorId(int clienteId);
    }
}
