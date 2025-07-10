using System;
using System.Linq;
using Ticketing.Modelos.Base;
using Ticketing.Modelos.Salas.Zonificacion;
using Ticketing.Modelos.Utils.Extensiones;
using Ticketing.Modelos.Utils.FechasYTiempo;
namespace Ticketing.Modelos.Programacion
{
    public class Funcion : Item
    {
        public Evento Evento { get; set; }
        public IFecha Fecha { get; set; }
        public Horario Horario { get; set; }
        public Zonas Zonas { get; set; }

        public double ObtenerPrecio(int zona = 0) {
            return Zonas.Lista[zona].Precio;
        }
        public bool DescuentosHabilitados { get; set; }

        public Funcion(Evento evento) : base(evento.Nombre)
        {
            Evento = evento ?? throw new ArgumentNullException(nameof(evento), "El evento no puede ser nulo.");
        }
        public DateTime Finaliza() => Fecha is FechaEspecifica fechaAsignada
                 ? fechaAsignada.Finalizacion(Evento.Duracion.Tiempo())
                 : throw new InvalidOperationException("No se ha especificado una fecha específica");

    }
}
