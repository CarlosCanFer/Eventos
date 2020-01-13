using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba.Validadores
{
    /// <summary>
    /// Clase encargado de validar un determinado día.
    /// </summary>
    public class ValidadorDia : IValidadorDia
    {
        /// <summary>
        /// Método encargado de validar un determinado día.
        /// </summary>
        /// <param name="_objDatos">Datos a evaluar.</param>
        /// <returns>Devuelve verdadero si los datos fueron evaluados correctamente de lo contrario devuelve falso.</returns>
        public bool ValidaDia(string _objDatos)
        {
            #region Declaraciones
            IVisualizamensaje visualizarmensaje = new VisualizarMensaje();

            string _cmensaje;
            string[] _cENombrefecha;
            int _idia;
            #endregion

            try
            {
                _cENombrefecha = _objDatos.Split(',');
                DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
                DateTime _dfechaHoy = DateTime.Now;
                if (_dfechaHoy.Day > _objDatos1.Day)
                {
                    _idia = (_dfechaHoy.Day) - (_objDatos1.Day);
                    _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrió hace: " + _idia + " días";
                    visualizarmensaje.mensaje(_cmensaje);
                    return true;
                }
                else
                {
                    if (_dfechaHoy.Day < _objDatos1.Day) {
                        _idia = (_objDatos1.Day) - (_dfechaHoy.Day);
                        _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _idia + " días";
                        visualizarmensaje.mensaje(_cmensaje);
                        return true;
                    }                       
                }
            }
            catch
            {
                _cmensaje = "El formato del archivo es incorrecto";
                visualizarmensaje.mensaje(_cmensaje);
                return false;
            }

            return false;
        }
    }
}
