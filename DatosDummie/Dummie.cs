using System;
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
            new Evento(1, "Concierto de Rock", "Un gran concierto de rock en vivo",
                new DetallesEvento(
                    "ruta/a/portada.jpg", 
                    new PeriodoDeTiempo(2, 30, 0),
                    new Idioma(new CultureInfo("es_MX")),
                    new Formato(1, "Cine", "Película en formato digital"),
                    new Clasificacion(1, "PG-13", "Apto para mayores de 13 años"))),
            new Evento(2, "Concierto de Rock", "Un gran concierto de rock en vivo",
                new DetallesEvento(
                    "ruta/b/portada.jpg", 
                    new PeriodoDeTiempo(2, 30, 0),
                    new Idioma(new CultureInfo("es_MX")),
                    new Formato(1, "Concierto", "Concierto en Vivo"),
                    new Clasificacion(1, "PG-13", "Apto para mayores de 13 años")))
        };
        public static List<Cartelera> carteleras = new List<Cartelera>
        {
                  new Cartelera(eventos[0], new Programacion(new FechaEspecifica(20,03,2025), new Horario(13,30)))
                  {
                      Id = 1,
                      Configuracion = new DetalleCartelera
                      {
                          ConDescuentos = true,
                          PrecioBase = 150.00,
                          Zonificacion = new ZonaUnica(150.00)
                      }
                  },
        };
    }
}
