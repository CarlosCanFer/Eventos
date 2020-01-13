using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba.Validadores
{
    /// <summary>
    /// Clase encargada de validar un determinado mes.
    /// </summary>
    public class ValidadorMes : IValidadorMes
    {
        /// <summary>
        /// Método que se encarga de validar los meses.
        /// </summary>
        /// <param name="_objDatos">Datos a validar</param>
        /// <returns>Devuelve una bandera verdadera si se cumple de lo contrario devuelve falso</returns>
        public bool ValidaMes(string _objDatos)
        {
            IVisualizamensaje visualizarmensaje = new VisualizarMensaje();

            string[] _cENombrefecha;
            string _cmensaje;
            int _imes;            
           
            try
            {
                _cENombrefecha = _objDatos.Split(',');
                DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
                DateTime _dfechaHoy = DateTime.Now;

                if (_dfechaHoy.Month > _objDatos1.Month)
                {
                    _imes = (_dfechaHoy.Month) - (_objDatos1.Month);
                    _cmensaje= "El evento " + _cENombrefecha[0] + " Ocurrió hace: " + _imes + " meses";
                    visualizarmensaje.mensaje(_cmensaje);
                    return true;
                }
                else
                {
                    if (_dfechaHoy.Month < _objDatos1.Month)
                    {
                        _imes = (_objDatos1.Month) - (_dfechaHoy.Month);
                        _cmensaje = "El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _imes + " meses";
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
