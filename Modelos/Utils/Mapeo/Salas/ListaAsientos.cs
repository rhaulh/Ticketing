using System.Collections.Generic;
using System.Linq;
using Ticketing.Modelos.Utils.Mapeo.Zonificacion;

namespace Ticketing.Modelos.Utils.Mapeo.Salas
{
    public class ListaAsientos
    {
        public List<Asiento> Asientos { get; set; } = new List<Asiento>();
        public new string ToString()
            {
                return string.Join(" ", Asientos
                       .Where(a => a != null)
                       .Select(a => a.Id.ToString())
            );
        }
    }
}
