using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba
{

    public class Validador : IValidador<String>
    {
        /// <summary>
        /// Método que se encarga de validar el día.
        /// </summary>
        /// <param name="_objDatos">Datos a verificar</param>
        /// <returns>Devuelve una vandera verdadera si se cumple de lo contrario devuelve falso</returns>
        public bool ValidaDia(String _objDatos)
        {
            string[] _cENombrefecha = _objDatos.Split(',');
            DateTime _objDatos1 =DateTime.Parse(_cENombrefecha[1]);
            DateTime _dfechaHoy = DateTime.Now;
            int _idia;
            try {               
                    if (_dfechaHoy.Day > _objDatos1.Day)
                    {
                        _idia = (_dfechaHoy.Day) - (_objDatos1.Day);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrio hace: " + _idia + " días");
                    return true;
                    }
                    else
                    {
                        _idia = (_objDatos1.Day) - (_dfechaHoy.Day);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _idia + " días");
                    return true;
                }                
            }
            catch {

                return false;
            }        
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Método que se encarga de validar las horas.
        /// </summary>
        /// <param name="_objDatos">Datos a verificar</param>
        /// <returns>Devuelve una vandera verdadera si se cumple de lo contrario devuelve falso</returns>
        public bool ValidaHora(String _objDatos)
        {
            string[] _cENombrefecha = _objDatos.Split(',');
            DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
            DateTime _dfechaHoy = DateTime.Now;
            int _ihora;
            try
            {               
                    if (_dfechaHoy.Hour > _objDatos1.Hour)
                    {
                        _ihora = (_dfechaHoy.Hour) - (_objDatos1.Hour);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrio hace: " + _ihora + " horas");
                    return true;
                }
                    else
                    {
                        _ihora = (_objDatos1.Hour) - (_dfechaHoy.Hour);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _ihora + " horas");
                    return true;
                }                
            }
            catch
            {

                return false;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método que se encarga de validar los meses.
        /// </summary>
        /// <param name="_objDatos">Datos a validar</param>
        /// <returns>Devuelve una vandera verdadera si se cumple de lo contrario devuelve falso</returns>
        public bool ValidaMes(String _objDatos)
        {
            string[] _cENombrefecha = _objDatos.Split(',');
            DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
            DateTime _dfechaHoy = DateTime.Now;
            int _imes;
            try
            {
                if (_dfechaHoy.Month > _objDatos1.Month)
                    {
                        _imes = (_dfechaHoy.Month) - (_objDatos1.Month);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrio hace: " + _imes + " meses");
                    return true;
                }
                    else
                    {
                        _imes = (_objDatos1.Month) - (_dfechaHoy.Month);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _imes + " meses");
                    return true;
                }                
            }
            catch
            {

                return false;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método que se encarga de validar los minutos.
        /// </summary>
        /// <param name="_objDatos">Datos a validar</param>
        /// <returns>Devuelve una vandera verdadera si se cumple de lo contrario devuelve falso</returns>
        public bool ValidaMinuto(String _objDatos)
        {
            string[] _cENombrefecha = _objDatos.Split(',');
            DateTime _objDatos1 = DateTime.Parse(_cENombrefecha[1]);
            DateTime _dfechaHoy = DateTime.Now;
            int _imunito;
            try
            {               
                    if (_dfechaHoy.Minute > _objDatos1.Minute)
                    {
                        _imunito = (_dfechaHoy.Minute) - (_objDatos1.Minute);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrio hace: " + _imunito + " minutos");
                    return true;
                }
                    else
                    {
                        _imunito = (_objDatos1.Minute) - (_dfechaHoy.Minute);
                        Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrirá en: " + _imunito + " minutos");
                    return true;
                }                
            }
            catch
            {

                return false;
            }
            throw new NotImplementedException();
        }

    }
}
