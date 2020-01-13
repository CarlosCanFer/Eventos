using EjerPrueba.Interfaces;
using EjerPrueba.Validadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EjerPruebaUTest.Validadores
{
    [TestClass]
   public class ValidaDiaUTest
    {
        [TestMethod]
        public void ValidaDia_Datoscorrectos_Verdadero()
        {
            //Arrange
            IValidadorDia objvalidamosdia = new ValidadorDia();
            string _cdatosValidar = "Mi cumpleanios , 19/01/2020 09:30";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosdia.ValidaDia(_cdatosValidar);

            //Assert
            Assert.AreEqual(true, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaDia_DatosActuales_Falso()
        {
            //Arrange
            IValidadorDia objvalidamosdia = new ValidadorDia();

            string _cdatosValidar = "micumple,"+ DateTime.Now;
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosdia.ValidaDia(_cdatosValidar);

            //Assert
            Assert.AreEqual(false, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaDia_DatosNulos_Exception()
        {
            //Arrange
            IValidadorDia objvalidamosdia = new ValidadorDia();

            string _cdatosValidar = "";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosdia.ValidaDia(_cdatosValidar);

            //Assert
            Assert.AreEqual(false, _resultadoFinal);
        }
    }
}
