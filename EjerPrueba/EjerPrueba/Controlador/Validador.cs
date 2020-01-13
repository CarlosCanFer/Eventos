using EjerPrueba.Interfaces;
using EjerPrueba.Validadores;
using System;

namespace EjerPrueba
{
    /// <summary>
    /// Clase que valida los datos de entrada de un determinado archivo.
    /// </summary>
    public class Validador
    {
        /// <summary>
        /// Método encargado de validar los datos de un determinado archivo.
        /// </summary>
        /// <param name="_cdatosValidar">Datos a validar</param>
        public static void ValidarDatosArchivo(string[] _cdatosValidar)
        {
            #region Declaraciones
            IVisualizamensaje objvisualizamenaje = new VisualizarMensaje();
            IValidadorMes objvalidamosmes = new ValidadorMes();
            IValidadorDia objvalidamosDia = new ValidadorDia();
            IValidadorHora objvalidamosHora = new ValidadorHora();
            IValidadorMinutos objvalidamosMinutos = new ValidadorMinutos();

            string _cnombreEvento;
            string _cmensaje;
            string[] _cENombrefecha;
            DateTime _cfechaEvento;
            DateTime _dHoy = DateTime.Now;
            #endregion
            #region Validación
            try
            {
                foreach (string _cvalor in _cdatosValidar)
                {   
                    _cENombrefecha = _cvalor.Split(',');
                    _cnombreEvento = _cENombrefecha[0];
                    _cfechaEvento = DateTime.Parse(_cENombrefecha[1]);

                    if (_dHoy.Month != _cfechaEvento.Month)
                    {
                        objvalidamosmes.ValidaMes(_cvalor);
                    }
                    else
                    {
                        if (_dHoy.Day != _cfechaEvento.Day)
                        {
                            objvalidamosDia.ValidaDia(_cvalor);
                        }
                        else
                        {
                            if (_dHoy.Hour != _cfechaEvento.Hour)
                            {
                                objvalidamosHora.ValidaHora(_cvalor);
                            }
                            else
                            {
                                if (_dHoy.Minute != _cfechaEvento.Minute)
                                {
                                    objvalidamosMinutos.ValidaMinuto(_cvalor);
                                }
                                else
                                {
                                   _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrió hace un momento";
                                    objvisualizamenaje.mensaje(_cmensaje);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                _cmensaje = "Los datos ingresados en el archivo son incorrectos";
                objvisualizamenaje.mensaje(_cmensaje);
            }
            #endregion
        }
    }
}
