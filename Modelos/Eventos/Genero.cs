using Ticketing.Modelos.Utils.Identificadores;

namespace Ticketing.Modelos.Eventos
{
    public class Genero:BaseID
    {
        public Genero(int id, string nombre, string descripcion) : base(id)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public Genero(int id) : base(id)
        {
            Nombre = "Desconocido";
            Descripcion = "Género no especificado";
        }
    }
}
