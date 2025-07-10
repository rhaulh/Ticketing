using System;
using Ticketing.Modelos.Programacion;

namespace Ticketing.Modelos.Utils
{
    public static class Validadores
    {
        public static void ValidarCartelera(this Cartelera otra)
        {
            if (otra == null || otra.Evento == null || otra.Evento.Duracion == null)
            {
                throw new ArgumentNullException(nameof(otra), "La cartelera proporcionada no es válida.");
            }
        }
        public static bool EsStringNula(this string valor,string nombreVariable)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
               // throw new ArgumentException($"El {nombreVariable} no puede ser nulo o vacío."); Patron Result
                return true;
            }
            return false;
        }
        public static bool EsNumeroNegativo(this int valor, string nombreVariable)
        {
            if (valor < 0)
            {
                // throw new ArgumentException($"El {nombreVariable} no puede ser nulo o vacío."); Patron Result
                return true;
            }
            return false;
        }
        public static bool EsPrecioNegativo(this double valor, string nombreVariable)
        {
            if (valor < 0)
            {
                // throw new ArgumentException($"El {nombreVariable} no puede ser nulo o vacío."); Patron Result
                return true;
            }
            return false;
        }
    }
}
