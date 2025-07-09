using System;
using System.Collections.Generic;
using Ticketing.Modelos.Utils.Identificadores;
using Ticketing.Modelos.Utils.Mapeo.Zonificacion;

namespace Ticketing.Modelos.Programacion
{
    public class AsientosDeZona:BaseID
    {
        public double Precio { get; set; }
        public string Fondo { get; set; }
        public List<Asiento> Asientos { get; set; }
        public AsientosDeZona(int zonaId,List<Asiento> asientos): base(zonaId)
        {
            Asientos = asientos ?? throw new ArgumentNullException(nameof(asientos), "Los asientos no pueden ser nulos.");
        }
    }
}
