using System;
using System.Collections.Generic;
using System.Linq;
using GAP.Procesos.Model.Repository.Polizas;
using GAP.Seguros.Entities;
using GAP.Seguros.Facade.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GAP.Seguros.Test
{
    [TestClass]
    public class PolizasTest
    {

        private Mock<IPolizasRepository> polizasMock = null;
        private PolizasFacade facade = null;


        [TestInitialize]
        public void InitializeTest()
        {
            this.polizasMock = new Mock<IPolizasRepository>();

            this.facade = new PolizasFacade(this.polizasMock.Object);
        }


        [TestMethod]
        public void ObtenerTodasLasPolizasPorClienteMock()
        {
            List<Poliza> polizas = new List<Poliza>()
                {
                 new Poliza()
                 {
                        ClienteId = 1,
                        Nombre = "Poliza todo vida",
                        Descripción = "Cubre incapacidad por accidente",
                        TipoCubrimientoId = 1,
                        Vigencia = new DateTime(),
                        Periodo = 24,
                        Precio = 120000,
                        Riesgo = Entities.Enums.RiesgosEnum.Alto,
                        Cobertura = 55
                 },
                   new Poliza()
                 {
                        ClienteId = 1,
                        Nombre = "Poliza todo vida",
                        Descripción = "Cubre incapacidad por accidente",
                        TipoCubrimientoId = 1,
                        Vigencia = new DateTime(),
                        Periodo = 24,
                        Precio = 120000,
                        Riesgo = Entities.Enums.RiesgosEnum.Alto,
                        Cobertura = 55
                 },
                     new Poliza()
                 {
                        ClienteId = 2,
                        Nombre = "Poliza todo vida",
                        Descripción = "Cubre incapacidad por accidente",
                        TipoCubrimientoId = 1,
                        Vigencia = new DateTime(),
                        Periodo = 24,
                        Precio = 120000,
                        Riesgo = Entities.Enums.RiesgosEnum.Alto,
                        Cobertura = 55
                 }

            };


            this.polizasMock.Setup(it => it.ObtenerPolizasPorCliente(It.IsAny<int>())).Returns<int>(id => polizas.Where(r => r.ClienteId == 2).ToList());
            var polizasActuales = this.facade.ObtenerPolizasPorCliente(2);

            Assert.AreEqual(1, polizasActuales.Count);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidarPolizaAltoRiesgoMock()
        {
            Poliza poliza = new Poliza()
            {
                ClienteId = 1,
                Nombre = "Poliza todo vida",
                Descripción = "Cubre incapacidad por accidente",
                TipoCubrimientoId = 1,
                Vigencia = new DateTime(),
                Periodo = 24,
                Precio = 120000,
                Riesgo = Entities.Enums.RiesgosEnum.Alto,
                Cobertura = 55

            };

            this.polizasMock.Setup(
                  it => it.GuardarPoliza(It.IsAny<Poliza>()));

            this.facade.GuardarPoliza(poliza);
        }
    }
}
