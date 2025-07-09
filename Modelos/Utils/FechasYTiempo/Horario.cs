using System;

namespace Ticketing.Modelos.Programacion
{
    public class Horario
    {
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }

        public Horario() { }
        public Horario(int hora, int minuto)
        {
            if (hora < 0 || minuto < 0)
                throw new ArgumentOutOfRangeException("Los valores de horas, minutos y segundos deben ser no negativos.");
            if (minuto >= 60)
                throw new ArgumentOutOfRangeException("Los minutos deben ser menores a 60");
            Hora = hora;
            Minuto = minuto;
            Segundo = 0;
        }
        public Horario(int hora, int minuto, int segundo)
        {
            if (hora < 0 || minuto < 0)
                throw new ArgumentOutOfRangeException("Los valores de horas, minutos y segundos deben ser no negativos.");
            if (minuto >= 60)
                throw new ArgumentOutOfRangeException("Los minutos deben ser menores a 60");
            Hora = hora;
            Minuto = minuto;
            Segundo = segundo;
        }
        public DateTime Tiempo => new DateTime(1, 1, 1, Hora, Minuto, Segundo);
        public new string ToString()
        {
            return $"{Hora:D2}:{Minuto:D2}:{Segundo:D2}";
        }
    }
}
