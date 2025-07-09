using System;

namespace Ticketing.Modelos
{
    public class DiaCompleto : IDuracion
    {
        public DateTime Fecha { get; set; }
        public TimeSpan Tiempo()
        {
            return new TimeSpan(24, 0, 0);
        }
    }
}
