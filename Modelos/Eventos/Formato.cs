using Ticketing.Modelos.Base;

namespace Ticketing.Modelos.Eventos
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
