using System;
using Ticketing.Modelos.Utils.Identificadores;
namespace Ticketing.Modelos.Programacion
{
    public class Cartelera : BaseID
    {
        public Evento Evento { get; set; }
        public Programacion Programacion { get; set; }
        public DetalleCartelera Configuracion { set; get; }
        public Cartelera(Evento evento, Programacion programacion) : base(0)
        {
            Evento = evento ?? throw new ArgumentNullException(nameof(evento), "El evento no puede ser nulo.");
            Programacion = programacion ?? throw new ArgumentNullException(nameof(programacion), "La programación no puede ser nula.");
            Programacion.Duracion = Evento.Detalles.Duracion.Tiempo();
        }
        public Cartelera(int eventoId, int id, Programacion horario) : base(id)
        {
            Evento = new Evento { Id = eventoId } ?? throw new ArgumentNullException("Debes Proporcionar ID del Evento");
            Evento.ObtenerDetalles();
            Programacion = horario ?? throw new ArgumentNullException(nameof(horario), "La programación no puede ser nula.");
        }
    }
}
