using System;
using Ticketing.Modelos.Base;
using Ticketing.Modelos.Utils;
namespace Ticketing.Modelos.Programacion
{
    public class Cartelera : Item
    {
        public Evento Evento { get; set; }
        public Programacion Programacion { get; set; }

        public double Precio { 
            get => Precio;
            set {
                Precio = value.EsPrecioNegativo(nameof(Precio))
                ? throw new ArgumentException($"El {nameof(Precio)} no puede ser negativo.")
                : value;
            } 
        }
        public IZonificacion Zonificacion { get; set; }
        public bool ConDescuentos { get; set; }

        public Cartelera(Evento evento, Programacion programacion) : base(evento.Nombre)
        {
            Evento = evento ?? throw new ArgumentNullException(nameof(evento), "El evento no puede ser nulo.");
            Programacion = programacion ?? throw new ArgumentNullException(nameof(programacion), "La programación no puede ser nula.");
            Programacion.Duracion = Evento.Duracion.Tiempo();
        }
        public void AgregarDetalle(DetalleCartelera detalleCartelera)
        {
            Precio = detalleCartelera.PrecioBase;
            Zonificacion = detalleCartelera.Zonificacion;
            ConDescuentos = detalleCartelera.ConDescuentos;
        }
    }
}
