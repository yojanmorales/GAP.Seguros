using GAP.Procesos.Model.Repository.TipoCubrimientos;
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
    public class TipoCubrimientosTest
    {
        private Mock<ITipoCrubimientosRepository> tipoCrubimientoMock = null;
        private TipoCubrimientosFacade facade = null;


        [TestInitialize]
        public void InitializeTest()
        {
            this.tipoCrubimientoMock = new Mock<ITipoCrubimientosRepository>();

            this.facade = new TipoCubrimientosFacade(this.tipoCrubimientoMock.Object);
        }

        [TestMethod]
        public void ObtenerTodosTipoCrubimientosMock()
        {
            List<TipoCubrimiento> tipoCubrimientos = new List<TipoCubrimiento>()
                {
                  new TipoCubrimiento() { Nombre = "Terremoto", Id=1 },
                     new TipoCubrimiento() { Nombre = "Incendio", Id=2 },
                     new TipoCubrimiento() { Nombre = "Robo", Id=3 },
                     new TipoCubrimiento() { Nombre = "Pérdida", Id=4 }

            };


            this.tipoCrubimientoMock.Setup(it => it.ObtenerTipoCubrimientos()).Returns(tipoCubrimientos);
            var tiposCubrimientosActuales = this.facade.ObtenerTipoCubrimientos();

            Assert.AreEqual(4, tiposCubrimientosActuales.Count);
        }
    }
}
