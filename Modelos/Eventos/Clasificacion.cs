using Ticketing.Modelos.Utils.Identificadores;

namespace Ticketing.Modelos
{
    public class Clasificacion:BaseID
    {
        public int EdadMinima { get; set; }
        public Clasificacion(int id, string nombre, string descripcion, int edadMinima) : base(id)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            EdadMinima = edadMinima;
        }
    }
}
