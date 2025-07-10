using System;
using Ticketing.Modelos.Base;
using Ticketing.Modelos.Salas.Zonificacion;
using Ticketing.Modelos.Utils.Extensiones;

namespace Ticketing.Modelos.Salas.Base
{
    public class Zona : Item
    {
        public string Fondo { get; set; } // Indicador visual de Zona
        public double Precio {
            get => Precio; 
            set {
                Precio = value.EsPrecioNegativo(nameof(Precio))
                ? throw new ArgumentException($"El {nameof(Precio)} no puede ser negativo.")
                : value;
            } }
        public Asientos Asientos { get; set; }
        public Zona(string nombre, double precio) : base (nombre)
        {
            Precio = precio;
        }
        public void Editar(Zona zona)
        {
            Nombre = zona.Nombre;
            Descripcion = zona.Descripcion;
            Precio = zona.Precio;
            Asientos = zona.Asientos;
        }
    }
}
