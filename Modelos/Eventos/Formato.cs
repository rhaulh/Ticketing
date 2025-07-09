using Ticketing.Modelos.Utils.Identificadores;

namespace Ticketing.Modelos
{
    public class Formato:BaseID
    {
        public Formato(int id, string nombre, string descripcion) : base(id)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
