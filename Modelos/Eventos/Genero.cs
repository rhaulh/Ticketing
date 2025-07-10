using Ticketing.Modelos.Base;
namespace Ticketing.Modelos.Eventos
{
    public class Genero:Item
    {
        public Genero(string nombre) : base(nombre)
        {
        }
        public Genero(string nombre, string descripcion) : base(nombre)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}

