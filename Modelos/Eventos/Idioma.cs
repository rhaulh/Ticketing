using System.Globalization;

namespace Ticketing.Modelos
{
    public class Idioma
    {
        public CultureInfo Nombre { get; set; }
        public Idioma(CultureInfo nombre)
        {
            Nombre = nombre;
        }

    }
}
