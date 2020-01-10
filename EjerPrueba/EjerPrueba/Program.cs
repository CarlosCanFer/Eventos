using System;
using System.IO;
using EjerPrueba.Interfaces;

namespace EjerPrueba
{
    public class Program
    {
        /// <summary>
        /// Main principal
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            ValidarDatos();
            Console.ReadLine();
        }

        /// <summary>
        /// Método que se encarga de leer el archivo de datos,
        /// </summary>
        /// <returns>Devuelve un conjunto de datos</returns>
        private static String[] DatosRecuperados() {
            string _cubicacionTexto = PedirRutaArchivo();
            string _ctextoentrada = File.ReadAllText(_cubicacionTexto);

            string[] _cdatostotal = _ctextoentrada.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            return _cdatostotal;
        }

        /// <summary>
        /// Método encargado de obtener la ruta del archivo a evaluar
        /// </summary>
        /// <returns>Regresa una cadena con la ruta del archivo</returns>
        public static String PedirRutaArchivo()
        {
            string _crutaArchivo;

            Console.WriteLine("Arraste la ruta del archivo que desea comprobar:");
            _crutaArchivo =Console.ReadLine();

            return _crutaArchivo;

        }       

        /// <summary>
        /// Método encargado de realizar la validacíon.
        /// </summary>
        public static void ValidarDatos() {
            String[] _dDatos = DatosRecuperados();
            IValidador<String> _objconsultas = new Validador();

            try
            {
                foreach (string _cvalor in _dDatos)
                {
                    string _cnombreEvento;
                    DateTime _cfechaEvento;
                    DateTime _dHoy = DateTime.Now;                    
                    string[] _cENombrefecha = _cvalor.Split(',');
                    _cnombreEvento = _cENombrefecha[0];
                    _cfechaEvento = DateTime.Parse(_cENombrefecha[1]);

                    if (_dHoy.Month != _cfechaEvento.Month)
                    {
                        _objconsultas.ValidaMes(_cvalor);
                    }
                    else {
                        if (_dHoy.Day != _cfechaEvento.Day)
                        {
                            _objconsultas.ValidaDia(_cvalor);
                        }
                        else {
                            if (_dHoy.Hour != _cfechaEvento.Hour)
                            {
                                _objconsultas.ValidaHora(_cvalor);
                            }
                            else {
                                if (_dHoy.Minute != _cfechaEvento.Minute)
                                {
                                    _objconsultas.ValidaMinuto(_cvalor);
                                }
                                else
                                {
                                    Console.WriteLine("El evento " + _cENombrefecha[0] + " Ocurrio hace un momento");
                                }
                            }
                        }
                    }                                     
                }
            }
            catch
            {
                Console.WriteLine("Los datos ingresados en el archivo son incorrectos");
            }
        }
    }
}
