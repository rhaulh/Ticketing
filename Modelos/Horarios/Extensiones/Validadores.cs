using System;
using System.Text.RegularExpressions;
using Ticketing.Modelos.Programacion;
using Ticketing.Modelos.Utils.Extensiones;


namespace Ticketing.Modelos.Horarios.Extensiones
{
    public static class Validadores
    {
        private static readonly Regex regex = new Regex(@"^\d{1,2}:\d{2}(:\d{2})?$");
        public static bool EsHorarioValido(this Horario horario)
        {
            if (horario.Hora < 0 || horario.Hora >= 24)
                // throw new ArgumentOutOfRangeException(nameof(horario.Hora), "La hora debe estar entre 0 y 23.");
            return false;
            if (horario.Minuto < 0 || horario.Minuto >= 60)
               // throw new ArgumentOutOfRangeException(nameof(horario.Minuto), "Los minutos deben estar entre 0 y 59.");
            return false;
            if (horario.Segundo < 0 || horario.Segundo >= 60)
              //throw new ArgumentOutOfRangeException(nameof(horario.Segundo), "Los segundos deben estar entre 0 y 59.");
                return false;
            return true;
        }
        public static bool EsFormatoHoraValido(this string hora)
        {
            if (!hora.EsStringNula(nameof(hora)) && regex.IsMatch(hora))
            {
                return true;
            }
            return false;
        }
    }
}
