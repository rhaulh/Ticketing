using Ticketing.Modelos.Base;

namespace Ticketing.Modelos
{
    public class Formato:Item
    {
        public Formato(string nombre, string descripcion) : base(nombre)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
