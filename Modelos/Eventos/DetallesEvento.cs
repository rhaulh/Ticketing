using Ticketing.Modelos.Utils.FechasYTiempo;

namespace Ticketing.Modelos.Eventos
{
    public class DetallesEvento
    {
        public string Portada { get; set; }
        public IDuracion Duracion { get; set; }
        public Idioma Idioma { get; set; }
        public Formato Formato { get; set; }
        public Clasificacion Clasificacion { get; set; }
        public DetallesEvento(string portada, IDuracion duracion, Idioma idioma, Formato formato, Clasificacion clasificacion)
        {
            Portada = portada;
            Duracion = duracion;
            Idioma = idioma;
            Formato = formato;
            Clasificacion = clasificacion;
        }
    }
}
