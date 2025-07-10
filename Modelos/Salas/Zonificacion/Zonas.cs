using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using Ticketing.Modelos.Programacion;

namespace Ticketing.Modelos.Salas.Zonificacion
{
    public class Zonas
    {
        private readonly List<Zona> _lista = new List<Zona>();
        public List<Zona> Lista => _lista;

        public bool EsZonaUnica => Cantidad == 1;
        public int Cantidad => Lista?.Count ?? 0;

        public Zonas(List<Zona> zonas)
        {
            _lista = zonas ?? throw new ArgumentNullException(nameof(zonas), "Las zonas por asientos no pueden ser nulas.");
        }

        public void Agregar(Zona zona)
        {
            _lista.Add(zona);
        }
        public void Eliminar(Zona zona)
        {
            _lista.Remove(zona);
        }
        public Zona Buscar(int id) { 
            return _lista.FirstOrDefault(e => e.Id == id);
        }
        public void Editar(int id, Zona zona)
        {
            var zonaOriginal = Buscar(id);
            zonaOriginal.Editar(zona);
        }
    }
}
