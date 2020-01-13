using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba.Validadores
{
    /// <summary>
    /// Clase encargada de validar una determinada fecha.
    /// </summary>
    public class ValidadorMinutos : IValidadorMinutos
    {
        /// <summary>
        /// Método que se encarga de validar los minutos.
        /// </summary>
        /// <param name="_objDatos">Datos a validar</param>
        /// <returns>Devuelve una bandera verdadera si se cumple de lo contrario devuelve falso</returns>
        public bool ValidaMinuto(string _objDatos)
        {
            IVisualizamensaje visualizarmensaje = new VisualizarMensaje();

            string _cmensaje;
            string[] _cENombrefecha;
            int _imunito;



            try
            {
            _cENombrefecha = _objDatos.Split(',');
            DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
            DateTime _dfechaHoy = DateTime.Now;

            if (_dfechaHoy.Minute > _objDatos1.Minute)
                {
                    _imunito = (_dfechaHoy.Minute) - (_objDatos1.Minute);
                    _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrió hace: " + _imunito + " minutos";
                    visualizarmensaje.mensaje(_cmensaje);
                    return true;
                }
                else
                {
                    if (_dfechaHoy.Minute < _objDatos1.Minute) {
                        _imunito = (_objDatos1.Minute) - (_dfechaHoy.Minute);
                        _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _imunito + " minutos";
                        visualizarmensaje.mensaje(_cmensaje);
                        return true;
                    }                      
                }
            }
            catch (Exception)
            {
                _cmensaje = "El formato del archivo es incorrecto";
                visualizarmensaje.mensaje(_cmensaje);
                return false;
            }

            return false;
        }
    }
}
