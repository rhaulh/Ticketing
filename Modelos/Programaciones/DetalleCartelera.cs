namespace Ticketing.Modelos.Programacion
{
    public class DetalleCartelera
    {
        public double PrecioBase { get; set; }
        public IZonificacion Zonificacion { get; set; }
        public bool ConDescuentos { get; set; }
    }
}
