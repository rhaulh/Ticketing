using System;
using Ticketing.Modelos.Horarios.Extensiones;

namespace Ticketing.Modelos.Programacion
{
    public class Horario
    {
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }

        public Horario(int hora, int minuto)
        {
            CrearHorario(hora, minuto, 0);
        }
        public Horario(DateTime fechaYHora)
        {
            CrearHorario(fechaYHora.Hour, fechaYHora.Minute, fechaYHora.Second);
        }
        public Horario(string hora)
        {
            hora.EsFormatoHoraValido();
            var h = hora.StringHoraToHorario();
            CrearHorario(h.Hora, h.Minuto, h.Segundo);
        }
        public Horario(int hora, int minuto, int segundo)
        {
            CrearHorario(hora, minuto, segundo);
        }

        private void CrearHorario(int hora, int minuto, int segundo)
        {
            Hora = hora;
            Minuto = minuto;
            Segundo = segundo;
            this.EsHorarioValido();
        }   
        public override string ToString()
        {
            return $"{Hora:D2}:{Minuto:D2}:{Segundo:D2}";
        }
    }
}
