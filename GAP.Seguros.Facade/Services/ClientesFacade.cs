using GAP.Procesos.Model.Repository.Clientes;
using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Seguros.Facade.Services
{
    public class ClientesFacade
    {
        private readonly IClientesRepository _ContextoRepositorio;
        public ClientesFacade()
            : this(new ClientesRepository())
        {
        }

        public ClientesFacade(IClientesRepository contextoRepositorio)
        {
            this._ContextoRepositorio = contextoRepositorio;
        }


        /// <summary>
        /// retorna un cliente por Idcliente
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns></returns>
        public Cliente ObtenerClientePorId(int clienteId)
        {
            return this._ContextoRepositorio.ObtenerClientePorId(clienteId);
        }


        /// <summary>
        /// Retorna todos los clientes
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerClientes()
        {
            return this._ContextoRepositorio.ObtenerClientes();
        }
    }
}
