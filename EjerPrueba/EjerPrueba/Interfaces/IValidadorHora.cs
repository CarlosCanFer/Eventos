using System;

namespace EjerPrueba.Interfaces
{
    public interface IValidadorHora
    {
        Func<DateTime> _objProveedorFecha { get; set; }
        bool ValidaHora(string _objDatos);
        
    }
}
