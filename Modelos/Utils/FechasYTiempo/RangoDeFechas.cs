using System;

namespace Ticketing.Modelos
{
    public class RangoDeFechas : IDuracion
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TimeSpan Tiempo()
        {
            return FechaFin - FechaInicio;
        }
    }
}
