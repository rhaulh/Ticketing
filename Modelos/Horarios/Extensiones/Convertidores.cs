using System;

namespace Ticketing.Modelos.Horarios.Extensiones
{
    public static class Convertidores
    {
        public static DateTime HorarioToDatetime(this Horario horario)
        {
            if (horario == null)
                throw new ArgumentNullException(nameof(horario), "El horario no puede ser nulo.");
            return new DateTime(1, 1, 1, horario.Hora, horario.Minuto, horario.Segundo);
        }
        public static Horario StringHoraToHorario(this string hora)
        {
            var partes = hora.Split(':');
            if (partes.Length < 2 || partes.Length > 3)
                throw new FormatException("El formato debe ser HH:mm o HH:mm:ss.");

            if (!int.TryParse(partes[0], out int h) || !int.TryParse(partes[1], out int m))
                throw new FormatException("Horas o minutos no válidos.");

            int s = 0;
            if (partes.Length == 3 && !int.TryParse(partes[2], out s))
                throw new FormatException("Segundos no válidos.");

            return new Horario(h, m, s);
        }
    }
}
