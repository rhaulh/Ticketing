using Ticketing.Modelos.Base;

namespace Ticketing.Modelos
{
    public class Formato:Item
    {
        public Formato(string nombre) : base(nombre)
        {
        }
        public Formato(string nombre, string descripcion) : base(nombre)
        {
            Descripcion = descripcion;
        }
    }
}
