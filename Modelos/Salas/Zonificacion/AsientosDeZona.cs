using System;
using System.Collections.Generic;
using Ticketing.Modelos.Base;
using Ticketing.Modelos.Utils.Mapeo.Zonificacion;

namespace Ticketing.Modelos.Programacion
{
    public class AsientosDeZona : Item
    {
        public double Precio { get; set; }
        public string Fondo { get; set; }
        public List<Asiento> Asientos { get; set; }
        public AsientosDeZona(string nombre, List<Asiento> asientos): base(nombre)
        {
            Asientos = asientos ?? throw new ArgumentNullException(nameof(asientos), "Los asientos no pueden ser nulos.");
        }
    }
}
