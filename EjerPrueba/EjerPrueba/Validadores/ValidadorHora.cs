using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba.Validadores
{
    /// <summary>
    /// Clase encargada de validar una determinada hora.
    /// </summary>
    public class ValidadorHora : IValidadorHora
    {        
        Func<DateTime> IValidadorHora._objProveedorFecha { get ; set ; }

        /// <summary>
        /// Método encargado de validar una determinada hora.
        /// </summary>
        /// <param name="_objDatos">Datos a evaluar.</param>
        /// <returns>Devuelve verdadero si los datos fueron evaluados correctamente de lo contrario devuelve falso.</returns>
        public bool ValidaHora(string _objDatos)
        {
            IVisualizamensaje visualizarmensaje = new VisualizarMensaje();

            string _cmensaje;
            string[] _cENombrefecha;
            int _ihora;
                                    
            try
            {
                _cENombrefecha = _objDatos.Split(',');
                DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
                DateTime _dfechaHoy = DateTime.Now;

                if (_dfechaHoy.Hour > _objDatos1.Hour)
                {
                    _ihora = (_dfechaHoy.Hour) - (_objDatos1.Hour);
                    _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrió hace: " + _ihora + " horas";
                    visualizarmensaje.mensaje(_cmensaje);                    
                    return true;
                }
                else
                {
                    if (_dfechaHoy.Hour < _objDatos1.Hour) {
                        _ihora = (_objDatos1.Hour) - (_dfechaHoy.Hour);
                        _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _ihora + " horas";
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
