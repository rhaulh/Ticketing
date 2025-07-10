using Ticketing.Modelos.Base;

public interface IRepositorio<T> where T : class
{
    void Agregar(T entidad);
    void Actualizar(T entidad);
    T Buscar(T entidad);
    void Eliminar(T entidad);
}