using System.Collections.Generic;
using Ticketing.Modelos;
using Ticketing.Modelos.Eventos;
using Ticketing.Modelos.Programaciones;

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
                new Idioma("es_MX"),
                new Formato("Cine", "Película en formato digital"),
                new Clasificacion("PG-13", "Apto para mayores de 13 años",13))),
            new Evento(
                "Concierto de Rock", "Un gran concierto de rock en vivo",
                new DetallesEvento(
                "ruta/b/portada.jpg",
                new PeriodoDeTiempo(2, 30, 0),
                new Idioma("es_MX"),
                new Formato("Concierto", "Concierto en Vivo"),
                new Clasificacion("PG-13", "Apto para mayores de 13 años", 13)))
        };
        public static List<Funcion> carteleras = new List<Funcion>
        {
            new Funcion(eventos[0])
            {
                Id = 1,
                DescuentosHabilitados = true
            },
        };
    }
}
