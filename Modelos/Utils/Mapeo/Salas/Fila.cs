using Ticketing.Modelos.Base;

namespace Ticketing.Modelos.Utils.Mapeo.Salas
{
   public class Fila : Item
    {
        public ListaAsientos Asientos { get; set; }
        public Fila():base("Fila Nueva")
        {
            Asientos = new ListaAsientos();
        }
        public Fila(string nombre, ListaAsientos asientos) : base($"Fila {nombre}")
        {
            Asientos = asientos;
        }
        public new string ToString()
        {
            return $"{Nombre} Asientos: ({Asientos})";
        }
    }
}
