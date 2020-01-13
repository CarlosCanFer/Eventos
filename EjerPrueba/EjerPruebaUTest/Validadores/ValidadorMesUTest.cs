using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjerPrueba.Interfaces;
using EjerPrueba.Validadores;
using System;

namespace EjerPruebaUTest.Validadores
{
    [TestClass]
    public class ValidarMesUTest
    {
        [TestMethod]
        public void ValidaMes_Datoscorrectos_Verdadero()
        {
            //Arrange
            IValidadorMes objvalidamosmes = new ValidadorMes();
            string _cdatosValidar = "Mi cumpleanios , 19/03/2020 09:30";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosmes.ValidaMes(_cdatosValidar);

            //Assert
            Assert.AreEqual(true, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaMes_DatosIguales_Falso()
        {
            //Arrange
            IValidadorMes objvalidamosmes = new ValidadorMes();

            string _cdatosValidar = "Micumple,"+DateTime.Now;
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosmes.ValidaMes(_cdatosValidar);

            //Assert
            Assert.AreEqual(false, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaMes_DatosNulos_false()
        {
            //Arrange
            IValidadorMes objvalidamosmes = new ValidadorMes();

            string _cdatosValidar = "";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosmes.ValidaMes(_cdatosValidar);

            //Assert
            Assert.AreEqual(false, _resultadoFinal);
        }
    }
}
