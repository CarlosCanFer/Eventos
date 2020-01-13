using EjerPrueba.Interfaces;
using System;

namespace EjerPrueba
{
    /// <summary>
    /// Clase encargado de visualizar un determinado mensaje.
    /// </summary>
    public class VisualizarMensaje : IVisualizamensaje
    {
        /// <summary>
        /// Método encargado de visualizar un determinado mensaje.
        /// </summary>
        /// <param name="mensaje">Mensaje a visualizar en consola.</param>
        public void mensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
