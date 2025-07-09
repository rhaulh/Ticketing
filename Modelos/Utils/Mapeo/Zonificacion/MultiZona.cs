using System;
using System.Collections.Generic;

namespace Ticketing.Modelos.Programacion
{
    public class MultiZona : IZonificacion
    {
        public List<AsientosDeZona> Zonas { get; set; }
        public MultiZona(List<AsientosDeZona> zonasPorAsientos)
        {
            Zonas = zonasPorAsientos ?? throw new ArgumentNullException(nameof(zonasPorAsientos), "Las zonas por asientos no pueden ser nulas.");
        }
        public int NumeroDeZonas => Zonas?.Count ?? 0;
    }
}
