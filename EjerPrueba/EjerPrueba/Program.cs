using System;
using System.IO;

namespace EjerPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            string _cubicacionTexto= @"C:\Datos\datos.txt";
            string _ctextoentrada = File.ReadAllText(_cubicacionTexto);

            string[] _cdatostotal = _ctextoentrada.Split(new string[] {Environment.NewLine},StringSplitOptions.None);

            foreach (string _cvalor in _cdatostotal)
            {
                string _cnombreEvento;
                DateTime _cfechaEvento;
                DateTime _dHoy = DateTime.Now;
                int _ianios, _imeses, _idias, _ihoras;               

                string[] _cENombrefecha = _cvalor.Split(',');
                _cnombreEvento = _cENombrefecha[0];
                _cfechaEvento = DateTime.Parse(_cENombrefecha[1]);

                if (_dHoy > _cfechaEvento)
                {
                    if (_dHoy.Year > _cfechaEvento.Year)
                    {
                        _ianios = (_dHoy.Year) - (_cfechaEvento.Year);

                        Console.WriteLine("El evento " + _cnombreEvento + " Ocurrio hace: " + _ianios + " años");
                    }
                    else
                    {
                        if (_dHoy.Month > _cfechaEvento.Month)
                        {
                            _imeses = (_dHoy.Month) - (_cfechaEvento.Month);
                            Console.WriteLine("El evento " + _cnombreEvento + " Ocurrio hace: " + _imeses + " meses");

                        }
                        else {
                            _idias = (_dHoy.Day) - (_cfechaEvento.Day);
                            Console.WriteLine("El evento " + _cnombreEvento + " Ocurrio hace: " + _idias + " días");
                        }
                    }
                }
                else {

                    if (_dHoy.Year < _cfechaEvento.Year)
                    {
                        _ianios = (_cfechaEvento.Year) - (_dHoy.Year);
                        Console.WriteLine("El evento " + _cnombreEvento + " Ocurrirá dentro de: " + _ianios + " años");
                    }
                    else
                    {
                        if (_dHoy.Month < _cfechaEvento.Month)
                        {
                            _imeses = (_cfechaEvento.Month)-(_dHoy.Month);
                            Console.WriteLine("El evento " + _cnombreEvento + " Ocurrirá dentro de: " + _imeses + " meses");

                        }
                        else
                        {
                            _idias = (_cfechaEvento.Day)- (_dHoy.Day);
                            Console.WriteLine("El evento " + _cnombreEvento + " Ocurrirá dentro de: " + _idias + " días");
                        }
                    }                  
                }
            }          
            Console.ReadLine();
        }
    }
}
