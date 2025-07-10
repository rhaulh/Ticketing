using System.Globalization;
using Ticketing.Modelos.Base;

namespace Ticketing.Modelos.Eventos
{
    public class Idioma : Item
    {
        public CultureInfo Cultura { get; set; }
        public Idioma(string cultura) : base(cultura)
        {
            Cultura = new CultureInfo(cultura);
        }
    }
}
