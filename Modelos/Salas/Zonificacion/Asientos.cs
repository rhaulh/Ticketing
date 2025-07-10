using System;
using System.Collections.Generic;
using System.Linq;
using Ticketing.Modelos.Utils.Mapeo.Zonificacion;

namespace Ticketing.Modelos.Programacion
{
    public class Asientos
    {
        private readonly List<Asiento> _lista = new List<Asiento>();
        public List<Asiento> Lista => _lista;
        public int Cantidad => Lista?.Count ?? 0;

        public Asientos(List<Asiento> asientos)
        {
            _lista = asientos ?? throw new ArgumentNullException(nameof(asientos), "Las zonas por asientos no pueden ser nulas.");
        }
        public void Agregar(Asiento asiento)
        {
            _lista.Add(asiento);
        }
        public void Eliminar(Asiento asiento)
        {
            _lista.Remove(asiento);
        }
        public Asiento Buscar(int id)
        {
            return _lista.FirstOrDefault(e => e.Id == id);
        }
        public void Editar(int id, Asiento asiento)
        {
            var asientoOriginal = Buscar(id);
            asientoOriginal.Editar(asiento);
        }
        public new string ToString()
        {
            return string.Join(" ", _lista
                   .Where(a => a != null)
                   .Select(a => a.Id.ToString())
        );
        }
    }
}
