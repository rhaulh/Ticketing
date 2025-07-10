using System.Globalization;
using Ticketing.Modelos.Base;

namespace Ticketing.Modelos
{
    public class Idioma : Item
    {
        public CultureInfo Cultura { get; set; }
        public Idioma(CultureInfo cultura) : base(cultura.Name)
        {
            Cultura = cultura;
        }
    }
}
