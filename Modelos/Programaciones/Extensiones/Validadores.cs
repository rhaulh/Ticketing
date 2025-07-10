using System;

namespace Ticketing.Modelos.Programaciones.Extensiones
{
   public static class Validadores
    {
        public static bool EsCarteleraValida(this Funcion otra)
        {
            if (otra == null || otra.Evento == null || otra.Evento.Duracion == null)
            {
                return false;
            }
            return true;
        }
    }
}
