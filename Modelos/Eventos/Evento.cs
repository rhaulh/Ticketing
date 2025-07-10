using Ticketing.Modelos.Base;
using Ticketing.Modelos.Utils.FechasYTiempo;

namespace Ticketing.Modelos.Eventos
{
    public class Evento : Item
    {
        public string Portada { get; set; }
        public IDuracion Duracion { get; set; }
        public Idioma Idioma { get; set; }
        public Formato Formato { get; set; }
        public Clasificacion Clasificacion { get; set; }

        public Evento(string nombre ) : base(nombre)
        {
            Nombre = nombre;
        }
        public Evento(string nombre, string descripcion, DetallesEvento detallesEvento) : base(nombre)
        {
           Descripcion = descripcion;
        }
        public Evento(string nombre, string descripcion, string portada, IDuracion duracion, Idioma idioma, Formato formato, Clasificacion clasificacion) : base(nombre)
        {
            Descripcion = descripcion;
            Portada = portada;
            Duracion = duracion;
            Idioma = idioma;
            Formato = formato;
            Clasificacion = clasificacion;
        }
        public void AgregarDetalles(DetallesEvento detallesEvento)
        {
            Portada = detallesEvento.Portada;
            Duracion = detallesEvento.Duracion;
            Idioma = detallesEvento.Idioma;
            Formato = detallesEvento.Formato;
            Clasificacion = detallesEvento.Clasificacion;
        }
        public void ObtenerDetalles()
        {
            // Lógica para obtener los detalles del evento.
           var Detalles = new DetallesEvento(
                "ruta/a/portada.jpg",
                new PeriodoDeTiempo(2, 30, 0),
                new Idioma("es_MX"),
                new Formato("Cine", "Película en formato digital"),
                new Clasificacion("PG-13", "Apto para mayores de 13 años", 13)
            );
            //Obtner de DB o Repositorio

        }
    }
}
