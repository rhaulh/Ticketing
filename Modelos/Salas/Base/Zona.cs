using Ticketing.Modelos.Base;

namespace Ticketing.Modelos.Programacion
{
    public class Zona : Item
    {
        public string Fondo { get; set; } // Indicador visual de Zona
        public double Precio { get; set; }
        public Asientos Asientos { get; set; }
        public Zona(string nombre, double precio) : base (nombre)
        {
            Precio = precio;
        }
        public void Editar(Zona zona)
        {
            Nombre = zona.Nombre;
            Descripcion = zona.Descripcion;
            Precio = zona.Precio;
            Asientos = zona.Asientos;
        }
    }
}
