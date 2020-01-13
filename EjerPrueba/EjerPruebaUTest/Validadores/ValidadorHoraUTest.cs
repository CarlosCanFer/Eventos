using EjerPrueba.Interfaces;
using EjerPrueba.Validadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EjerPruebaUTest.Validadores
{
    [TestClass]
    public class ValidadorHoraUTest
    {
        [TestMethod]
        public void ValidaHora_Datoscorrectos_Verdadero()
        {
            //Arrange
            IValidadorHora objvalidamoshora = new ValidadorHora();
            string _cdatosValidar = "Mi cumpleanios , 19/01/2020 09:30";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamoshora.ValidaHora(_cdatosValidar);

            //Assert
            Assert.AreEqual(true, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaHora_Datosiguales_Falso()
        {
            //Arrange
            IValidadorHora objvalidamoshora = new ValidadorHora();

            string _cdatosValidar = "micumple,"+ DateTime.Now;
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamoshora.ValidaHora(_cdatosValidar);

            //Assert

            Assert.AreEqual(false, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaHora_DatosNulos_Exception()
        {
            //Arrange
            IValidadorHora objvalidamoshora = new ValidadorHora();

            string _cdatosValidar = "";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamoshora.ValidaHora(_cdatosValidar);

            //Assert
           
            Assert.AreEqual(false, _resultadoFinal);
        }
    }
}
