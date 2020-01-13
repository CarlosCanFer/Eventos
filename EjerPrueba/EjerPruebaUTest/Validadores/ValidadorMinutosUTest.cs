using EjerPrueba.Interfaces;
using EjerPrueba.Validadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EjerPruebaUTest.Validadores
{
    [TestClass]
    public class ValidadorMinutosUTest
    {
        [TestMethod]
        public void ValidaMinutos_Datoscorrectos_Verdadero()
        {
            //Arrange
            IValidadorMinutos objvalidamosminutos = new ValidadorMinutos();
            string _cdatosValidar = "Mi cumpleanios , 19/01/2020 09:30";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosminutos.ValidaMinuto(_cdatosValidar);

            //Assert
            Assert.AreEqual(true, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaMinutos_Datosiguales_Falso()
        {
            //Arrange
            IValidadorMinutos objvalidamosminutos = new ValidadorMinutos();

            string _cdatosValidar = "micumple,"+DateTime.Now;
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosminutos.ValidaMinuto(_cdatosValidar);

            //Assert

            Assert.AreEqual(false, _resultadoFinal);
        }

        [TestMethod]
        public void ValidaMinuto_DatosNulos_Falso()
        {
            //Arrange
            IValidadorMinutos objvalidamosminutos = new ValidadorMinutos();

            string _cdatosValidar = "";
            bool _resultadoFinal;

            //Act
            _resultadoFinal = objvalidamosminutos.ValidaMinuto(_cdatosValidar);

            //Assert           
            Assert.AreEqual(false, _resultadoFinal);
        }

    }
}
