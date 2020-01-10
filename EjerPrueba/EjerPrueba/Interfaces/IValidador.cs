namespace EjerPrueba.Interfaces
{
    /// <summary>
    /// Interfaz para validar los datos de entrada.
    /// </summary>
    public interface IValidador<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        bool ValidaMes(T _objDatos);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        bool ValidaDia(T _objDatos);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        bool ValidaHora(T _objDatos);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_objDatos"></param>
        /// <returns></returns>
        bool ValidaMinuto(T _objDatos);

    }
}
