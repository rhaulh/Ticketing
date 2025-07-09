using System;
using System.Text.RegularExpressions;
using Ticketing.Modelos.Utils.Validaciones;

namespace Ticketing.Modelos.Programacion
{
    public class Horario
    {
        private static readonly Regex regex = new Regex(@"^\d{1,2}:\d{2}(:\d{2})?$");
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }

        public Horario(int hora, int minuto)
        {
            var horario = new Horario(hora, minuto, 0);
        }
        private Horario(int hora, int minuto, int segundo)
        {
            Hora = hora;
            Minuto = minuto;
            Segundo = segundo;
            this.ValidarHorario();
        }
        public Horario(DateTime fechaYHora)
        {
            Hora = fechaYHora.Hour;
            Minuto = fechaYHora.Minute;
            Segundo = fechaYHora.Second;
        }
        public Horario(string hora)
        {
            if (string.IsNullOrWhiteSpace(hora))
                throw new ArgumentNullException(nameof(hora), "La cadena de hora no puede ser nula o vacía.");
            if (!regex.IsMatch(hora))
                throw new FormatException("El formato de la hora no es válido. Debe ser HH:mm o HH:mm:ss.");

            string[] partes = hora.Split(':');

            int h = int.Parse(partes[0]);
            int m = int.Parse(partes[1]);
            int s = partes.Length == 3 ? int.Parse(partes[2]) : 0;

            ValidarRango(h, m, s);

            Hora = h;
            Minuto = m;
            Segundo = s;
        }

        public override string ToString()
        {
            return $"{Hora:D2}:{Minuto:D2}:{Segundo:D2}";
        }
    }
}
