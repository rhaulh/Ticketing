using Ticketing.Modelos.Base;
using Ticketing.Modelos.Salas.Base.Enums;

namespace Ticketing.Modelos.Utils.Mapeo.Zonificacion
{
    public class Asiento : Item
    {
        public int SalaId { get; set; }
        public int CarteleraId { get; set; } 
        public int Fila { get; set; }
        public int Numero { get; set; }
        public int Zona { get; set; }
        public double Precio { get; set; }
        public TipoAsiento Tipo { get; set; }
        public EstadoAsiento Estado { get; set; }

        public Asiento(int salaId, int carteleraId, int fila, int numero, int zona, double precio, TipoAsiento tipo, EstadoAsiento estado) :base ($"Asiento {fila}-{numero}")
        {
            Id = salaId * 10000 + fila * 100 + numero; ////////////////
            SalaId = salaId;
            CarteleraId = carteleraId;
            Fila = fila;
            Numero = numero;
            Zona = zona;
            Precio = precio;
            Tipo = tipo;
            Estado = estado;
        }
        public void Editar(Asiento asiento)
        {
            SalaId = asiento.SalaId;
            CarteleraId = asiento.CarteleraId;
            Fila = asiento.Fila;
            Numero = asiento.Numero;
            Zona = asiento.Zona;
            Precio = asiento.Precio;
            Tipo = asiento.Tipo;
            Estado = asiento.Estado;
        }
        public new string ToString()
        {
            return $"Asiento {Fila}-{Numero} (Zona: {Zona}, Precio: {Precio}, Tipo: {Tipo}, Estado: {Estado})";
        }
    }
}
