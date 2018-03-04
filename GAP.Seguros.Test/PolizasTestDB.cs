using GAP.Seguros.Api.Controllers;
using GAP.Seguros.Entities;
using GAP.Seguros.Facade.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Seguros.Test
{
    [TestClass]
    public class PolizasTestDB
    {

        PolizasController controller;

        [TestInitialize]
        public void InitializeTest()
        {

            this.controller = new PolizasController();
        }

        [TestMethod]

        public void GuardarPoliticaBaseDeDatos()
        {


            Poliza poliza = new Poliza()
            {
                ClienteId = 1,
                Nombre = "Poliza todo vida",
                Descripción = "Cubre incapacidad por accidente",
                TipoCubrimientoId = 1,
                Vigencia = DateTime.Now,
                Periodo = 24,
                Precio = 120000,
                Riesgo = Entities.Enums.RiesgosEnum.Bajo,
                Cobertura = 40
            };
            this.controller.GuardarPoliza(poliza);

            Assert.IsNotNull(poliza.Id);


        }
    }
}
