using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba.Presentacion
{
    /// <summary>
    /// Clase encargado de solicitar los datos al usuario.
    /// </summary>
    public class SolicitaDatos : ISolicitaDatos
    {
        /// <summary>
        /// Método encargado de solicitar los datos al usuario.
        /// </summary>
        /// <returns>Datos insertado por parte del usuario</returns>
        public string Recuperadatos()
        {
            string _cDatoEntrada;
            _cDatoEntrada = Console.ReadLine();

            return _cDatoEntrada;
        }
    }
}
