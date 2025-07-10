using System;
using Ticketing.Modelos.Base;
using Ticketing.Modelos.Utils.Extensiones;

namespace Ticketing.Modelos
{
    public class Clasificacion:Item
    {
        public int EdadMinima { 
            get => EdadMinima;
            set {
                EdadMinima = value.EsNumeroNegativo(nameof(EdadMinima)) 
                    ? throw new ArgumentOutOfRangeException($"La {nameof(EdadMinima)} no puede ser negativa.") 
                    : value;
            }
        }
        public Clasificacion(string nombre, string descripcion, int edadMinima) : base(nombre)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            EdadMinima = edadMinima;
        }
    }
}
