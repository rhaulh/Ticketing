using System;
using Ticketing.Modelos.Utils.Extensiones;

namespace Ticketing.Modelos.Base
{
    public class Item
    {
        public int Id { get; set; }
        public string Nombre
        {
            get => Nombre;
            set
            {
                Nombre = value.EsStringNula(nameof(Nombre)) 
                    ? throw new ArgumentNullException($"El {nameof(Nombre)} no puede ser nulo o vacío.") 
                    : value;
            }
        }
        public string Descripcion {
            get => Descripcion;
            set
            {
                Descripcion = value.EsStringNula(nameof(Descripcion)) 
                    ? throw new ArgumentNullException($"El {nameof(Descripcion)} no puede ser nulo o vacío.") 
                    : value;
            } 
        }

        public Item(string nombre)
        {       
            Nombre = nombre.EsStringNula(nameof(nombre)) 
                ? throw new ArgumentNullException($"El {nameof(nombre)} no puede ser nulo o vacío.") 
                : nombre;
        }
    }
}
