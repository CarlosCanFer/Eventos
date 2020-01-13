using EjerPrueba.Interfaces;
using System.IO;

namespace EjerPrueba.Validadores
{
    /// <summary>
    /// Clase encargada de leer el contenido de una determinada ruta.
    /// </summary>
   public class RecuperadorDatos : IRecuperadorDatos
    {
        /// <summary>
        /// Método que se encarga de leer el archivo de datos.
        /// </summary>
        /// <param name="_crutaArchivo">Ruta del archivo</param>
        /// <returns>Devuelve un conjunto de datos</returns>
        public string[] Recuperardatos(string _crutaArchivo)
        {
            string[] _ctextoEntrada= {};
            string _cmensaje;
            IVisualizamensaje objmensaje = new VisualizarMensaje();

            if (File.Exists(_crutaArchivo))
            {
                _ctextoEntrada = File.ReadAllLines(_crutaArchivo);                

            }               
            else {
                _cmensaje = "La ruta que se agregó no existe";                
                objmensaje.mensaje(_cmensaje);                
            }
            return _ctextoEntrada;
        }        
    }
}
