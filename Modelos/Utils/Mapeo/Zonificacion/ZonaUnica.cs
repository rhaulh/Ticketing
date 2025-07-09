using System.Collections.Generic;

namespace Ticketing.Modelos.Programacion
{
    public class ZonaUnica : IZonificacion
    {
        public double Precio { get; set; }
        public List<AsientosDeZona> Zona { get; set; }
        public ZonaUnica(double precio)
        {
            Precio = precio;
            Zona = new List<AsientosDeZona>();
        }
    }
}
