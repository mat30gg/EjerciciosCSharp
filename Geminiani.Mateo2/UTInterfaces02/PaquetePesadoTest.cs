using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLInterfaces02;

namespace UTInterfaces02
{
    [TestClass]
    class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoEnvioMasImpuestosAfipYAduana()
        {
            //Arrange
            const decimal valorEsperado = 160;
            const decimal costoEnvio = 100;
            PaquetePesado test = new PaquetePesado("test", costoEnvio, "test", "test", 0);

            //Act
            decimal valRec = test.AplicarImpuestos();

            //Assert
            Assert.AreEqual(valorEsperado, valRec);

        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //Arrange
            const decimal valorEsperado = 25;
            const decimal costoEnvio = 100;
            PaquetePesado test = new PaquetePesado("test", costoEnvio, "test", "test", 0);

            //Act
            decimal valRec = ((IAfip)test).Impuestos;

            //Assert
            Assert.AreEqual(valorEsperado, valRec);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            const decimal valorEsperado = 35;
            const decimal costoEnvio = 100;
            PaquetePesado test = new PaquetePesado("test", costoEnvio, "test", "test", 0);

            //Act
            decimal valRec = test.Impuestos;

            //Assert
            Assert.AreEqual(valorEsperado, valRec);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange
            PaquetePesado test = new PaquetePesado("test", 1, "test", "test", 1);

            //Act
            bool valReto = test.TienePrioridad;

            //Assert
            Assert.IsFalse(valReto);
        }
    }
}
