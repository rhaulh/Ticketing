using System;
using Ticketing.Modelos.Programacion;

namespace Ticketing.Modelos.Utils.Validaciones
{
    public static class Extensiones
    {
        public static void ValidarCartelera(this Cartelera otra)
        {
            if (otra == null || otra.Evento == null || otra.Evento.Detalles?.Duracion == null)
            {
                throw new ArgumentNullException(nameof(otra), "La cartelera proporcionada no es válida.");
            }
        }
    }
}
