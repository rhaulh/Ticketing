using Ticketing.Modelos.Base;
using Ticketing.Modelos.Programacion;

namespace Ticketing.Modelos.Utils.Mapeo.Salas
{
   public class Fila : Item
    {
        public Asientos Asientos { get; set; }
        public Fila():base("Fila Nueva")
        {
        }
        public Fila(string nombre, Asientos asientos) : base($"Fila {nombre}")
        {
            Asientos = asientos;
        }
        public new string ToString()
        {
            return $"{Nombre} Asientos: ({Asientos})";
        }
    }
}
