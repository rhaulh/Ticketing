using System;
using Ticketing.Modelos.Base;
using Ticketing.Modelos.Utils.Extensiones;
using Ticketing.Modelos.Utils.FechasYTiempo;
namespace Ticketing.Modelos.Programacion
{
    public class Funcion : Item
    {
        public Evento Evento { get; set; }
        public IFecha Fecha { get; set; }
        public Horario Horario { get; set; }

        public IZonificacion Zonificacion { get; set; }

        public double Precio {
            get {
                return Precio;
            }
            set {
                Precio = value.EsPrecioNegativo(nameof(Precio))
                ? throw new ArgumentException($"El {nameof(Precio)} no puede ser negativo.")
                : value;
            }
        }
        public bool ConDescuentos { get; set; } //Lista de descuentos

        public Funcion(Evento evento) : base(evento.Nombre)
        {
            Evento = evento ?? throw new ArgumentNullException(nameof(evento), "El evento no puede ser nulo.");
        }
        public DateTime Finaliza()
        {
            if (Fecha is FechaEspecifica fechaAsignada)
            {
                return fechaAsignada.Finalizacion(Evento.Duracion.Tiempo());
            }
            throw new InvalidOperationException("No se ha especificado una fecha especifica");
        }

    }
}
