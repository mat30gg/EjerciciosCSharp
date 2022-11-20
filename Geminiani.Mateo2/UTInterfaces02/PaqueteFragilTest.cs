using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLInterfaces02;

namespace UTInterfaces02
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange
            const decimal valorEsperado = 135;
            const decimal costoEnvio = 100;
            PaqueteFragil test = new PaqueteFragil("test", costoEnvio, "test", "test", 1);

            //Act
            decimal valRet = test.AplicarImpuestos();

            //Assert
            Assert.AreEqual(valorEsperado, valRet);
        }
        [TestMethod]
        public void Impuesto_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            const decimal valorEsperado = 35;
            const decimal costoEnvio = 100;
            PaqueteFragil test = new PaqueteFragil("test", costoEnvio, "test", "test", 1);

            //Act
            decimal valRet = test.Impuestos;

            //Assert
            Assert.AreEqual(valorEsperado, valRet);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil test = new PaqueteFragil("test", 1, "test", "test", 1);

            //Act
            bool valorRetornado = test.TienePrioridad;

            //Assert
            Assert.IsTrue(valorRetornado);
        }
    }
}
