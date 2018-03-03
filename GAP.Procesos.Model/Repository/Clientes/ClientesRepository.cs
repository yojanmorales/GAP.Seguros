using GAP.Procesos.Model.Dao;
using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.Clientes
{
    public class ClientesRepository : IClientesRepository
    {


        private readonly ClientesDao _clientesDao;



        public ClientesRepository()
        {
            _clientesDao = new ClientesDao();
        }
        /// <summary>
        /// retorna un cliente por Idcliente
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns></returns>
        public Cliente ObtenerClientePorId(int clienteId)
        {
            return _clientesDao.ObtenerClientePorId(clienteId);
        }


        /// <summary>
        /// Retorna todos los clientes
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerClientes()
        {
            return _clientesDao.ObtenerClientes();
        }
    }
}
