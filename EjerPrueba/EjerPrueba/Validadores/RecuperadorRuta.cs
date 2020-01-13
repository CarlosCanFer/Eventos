using EjerPrueba.Interfaces;
using EjerPrueba.Presentacion;

namespace EjerPrueba.Validadores
{
    /// <summary>
    /// Clase encargado de obtener la ruta del archivo a evaluar.
    /// </summary>
    public class RecuperadorRuta : IRecuperadorRuta
    {
        /// <summary>
        /// Método encargado de obtener la ruta del archivo a evaluar.
        /// </summary>        
        /// <returns>Regresa una cadena con la ruta del archivo.</returns>
        public string RecuperaRuta()
        {
            ISolicitaDatos objdatosRecuperados = new SolicitaDatos();
            string _crutaArchivo;
            _crutaArchivo = objdatosRecuperados.Recuperadatos();

            return _crutaArchivo;
        }
    }
}
