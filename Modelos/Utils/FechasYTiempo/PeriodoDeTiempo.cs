using System;

namespace Ticketing.Modelos
{
    public class PeriodoDeTiempo : IDuracion
    {
        public PeriodoDeTiempo(int horas, int minutos, int segundos)
        {
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;
        }

        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }
        public TimeSpan Tiempo()
        {
            return new TimeSpan(Horas, Minutos, Segundos);
        }
    }
}
