using System.Collections.Generic;
using System.Globalization;
using Ticketing.Modelos;
using Ticketing.Modelos.Programacion;
using Ticketing.Modelos.Utils.FechasYTiempo;

namespace Ticketing.DatosDummie
{
    public static class Dummie
    {
        public static List<Evento> eventos = new List<Evento>
        {
            new Evento(
                "Concierto de Rock", "Un gran concierto de rock en vivo",
                new DetallesEvento(
                "ruta/a/portada.jpg",
                new PeriodoDeTiempo(2, 30, 0),
                new Idioma(new CultureInfo("es_MX")),
                new Formato("Cine", "Película en formato digital"),
                new Clasificacion("PG-13", "Apto para mayores de 13 años",13))),
            new Evento(
                "Concierto de Rock", "Un gran concierto de rock en vivo",
                new DetallesEvento(
                "ruta/b/portada.jpg",
                new PeriodoDeTiempo(2, 30, 0),
                new Idioma(new CultureInfo("es_MX")),
                new Formato("Concierto", "Concierto en Vivo"),
                new Clasificacion("PG-13", "Apto para mayores de 13 años", 13)))
        };
        public static List<Cartelera> carteleras = new List<Cartelera>
        {
            new Cartelera(eventos[0], new Programacion(new FechaEspecifica(20,03,2025), new Horario(13,30)))
            {
                Id = 1,
                ConDescuentos = true,
                Precio= 150.00,
                Zonificacion = new ZonaUnica(150.00)
            },
        };
    }
}
