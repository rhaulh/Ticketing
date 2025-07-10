using System;
using Ticketing.Modelos.Programacion;

namespace Ticketing.Modelos.Programaciones.Extensiones
{
   public static class Validadores
    {
        public static void EsCarteleraValida(this Funcion otra)
        {
            if (otra == null || otra.Evento == null || otra.Evento.Duracion == null)
            {
                throw new ArgumentNullException(nameof(otra), "La cartelera proporcionada no es válida.");
            }
        }
    }
}
