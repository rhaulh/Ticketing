using System;
using System.Globalization;
using Ticketing.Modelos.Utils.Identificadores;

namespace Ticketing.Modelos
{
    public class Evento : BaseID
    {
        public DetallesEvento Detalles { get; set; }
        public Evento() : base(0) { }
        public Evento(int id, string nombre, string descripcion, DetallesEvento detallesEvento) : base(id)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del evento no puede estar vacío.", nameof(nombre));
            }
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción del evento no puede estar vacía.", nameof(descripcion));
            }

        }
        public void ObtenerDetalles()
        {
            // Lógica para obtener los detalles del evento.
            Detalles = new DetallesEvento(
                "ruta/a/portada.jpg",
                new PeriodoDeTiempo(2, 30, 0),
                new Idioma(new CultureInfo("es_MX")),
                new Formato(1, "Cine", "Película en formato digital"), //UUIDs
                new Clasificacion(1,"PG-13", "Apto para mayores de 13 años") //UUIDs
            );
            //Obtner de DB o Repositorio

        }
    }
}
