using GAP.Procesos.Model.Repository.Clientes;
using GAP.Seguros.Entities;
using GAP.Seguros.Facade.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Seguros.Test
{
    [TestClass]
    public class ClientesTest
    {

        private Mock<IClientesRepository> clientesMock = null;
        private ClientesFacade facade = null;


        [TestInitialize]
        public void InitializeTest()
        {
            this.clientesMock = new Mock<IClientesRepository>();

            this.facade = new ClientesFacade(this.clientesMock.Object);
        }


        [TestMethod]
        public void ObtenerClientePorIdMock()
        {
            List<Cliente> clientes = new List<Cliente>()
                {
                 new Cliente()
                 {
                       Id = 1,
                        Nombre ="Elena Martinez",
                        Identificacion="1128"
                 },
                  new Cliente()
                 {
                       Id = 2,
                        Nombre ="Pedro Ramirez",
                        Identificacion="1129"
                 }

            };


            this.clientesMock.Setup(it => it.ObtenerClientePorId(It.IsAny<int>())).Returns<int>(id => clientes.FirstOrDefault(r => r.Id == 2));
            var clienteActual = this.facade.ObtenerClientePorId(2);

            Assert.AreEqual(2, clienteActual.Id);
        }


        [TestMethod]
        public void ObtenerTodosLosClientesMock()
        {
            List<Cliente> clientes = new List<Cliente>()
                {
                 new Cliente()
                 {
                       Id = 1,
                        Nombre ="Elena Martinez",
                        Identificacion="1128"
                 },
                  new Cliente()
                 {
                       Id = 2,
                        Nombre ="Pedro Ramirez",
                        Identificacion="1129"
                 }

            };


            this.clientesMock.Setup(it => it.ObtenerClientes()).Returns(clientes);
            var clientesActuales = this.facade.ObtenerClientes();

            Assert.AreEqual(2, clientesActuales.Count);
        }

    }
}
