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
    class GestionImpuestoTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange
            const decimal valorEsperado = 105;
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaquetePesado("TEST", 100, "TEST", "TEST", 0));
            paquetes.Add(new PaqueteFragil("TEST", 300, "TEST", "TEST", 0));
            GestionImpuestos test = new GestionImpuestos();

            test.RegistrarImpuestos(paquetes);

            //Act
            decimal valRes = test.CalcularTotalImpuestosAduana();

            //Assert
            Assert.AreEqual(valorEsperado, valRes);
        }
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange
            const decimal valorEsperado = 75;
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaquetePesado("TEST", 300, "TEST", "TEST", 0));
            paquetes.Add(new PaqueteFragil("TEST", 100, "TEST", "TEST", 0));
            GestionImpuestos test = new GestionImpuestos();

            test.RegistrarImpuestos(paquetes);

            //Act
            decimal valRes = test.CalcularTotalImpuestosAfip();

            //Assert
            Assert.AreEqual(valorEsperado, valRes);
        }
    }
}
