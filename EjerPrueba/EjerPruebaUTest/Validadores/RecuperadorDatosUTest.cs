using EjerPrueba.Interfaces;
using EjerPrueba.Validadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EjerPruebaUTest.Validadores
{
    [TestClass]
    public class RecuperadorDatosUTest
    {
        [TestMethod]
        public void RecuperadorDatos_RutaNula_Regresadatosvacios()
        {
            //Arrange
            IRecuperadorDatos objrecuperadorDatos = new RecuperadorDatos();
            string _crutaArchivo = "8597345385rsdfsdf";
            string[] _cresltado;

            //Act
            _cresltado = objrecuperadorDatos.Recuperardatos(_crutaArchivo);

            //Assert
            Assert.IsNotNull(_cresltado);
        }
    }
}
