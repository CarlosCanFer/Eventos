using System;
using EjerPrueba.Interfaces;
using EjerPrueba.Presentacion;
using EjerPrueba.Validadores;

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
            IVisualizamensaje objvisualizadorMensaje = new VisualizarMensaje();
            IRecuperadorRuta objrutaArchivo = new RecuperadorRuta();
            IRecuperadorDatos objdatosRecuperador = new RecuperadorDatos();

            string _cdatos;
            string _cdatosRuta;
            string[] _cdatosArchivo;
            _cdatos = "Insertar la ruta del archivo que desea comprobar:";
             objvisualizadorMensaje.mensaje(_cdatos);
            _cdatosRuta = objrutaArchivo.RecuperaRuta();
            _cdatosArchivo = objdatosRecuperador.Recuperardatos(_cdatosRuta);            

            Validador.ValidarDatosArchivo(_cdatosArchivo);

            Console.ReadLine();
        }        
    }
}
