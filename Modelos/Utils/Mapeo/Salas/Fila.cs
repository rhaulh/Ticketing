using Ticketing.Modelos.Utils.Identificadores;
using Ticketing.Modelos.Utils.Convertidores;
namespace Ticketing.Modelos.Utils.Mapeo.Salas
{
   public class Fila : BaseID
    {
        public ListaAsientos Asientos { get; set; }
        public Fila():base(0)
        {
        }
        public Fila(int id):base(id)
        {
            Id = id;
            Nombre = $"Fila {Id.IdToString()}";
            Asientos = new ListaAsientos();
        }
        public new string ToString()
        {
            return $"{Nombre} Asientos: ({Asientos})";
        }
    }
}
