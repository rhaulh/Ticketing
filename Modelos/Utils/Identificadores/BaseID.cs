namespace Ticketing.Modelos.Utils.Identificadores
{
    public class BaseID
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public BaseID(int id)
        {
            Id = id;
        }
    }
}
