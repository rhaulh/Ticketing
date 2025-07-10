using System.Collections.Generic;
using System.Linq;

namespace Ticketing.Repositorios.Base
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly List<T> _lista;
        public Repositorio(List<T> lista)
        {
            _lista = lista;
        }
        public void Actualizar(T entidad)
        {
            var entidadOriginal = Buscar(entidad);
        }

        public void Agregar(T entidad)
        {
            _lista.Add(entidad);
        }

        public T Buscar(T entidad)
        {
            return _lista.FirstOrDefault(e => e.Equals(entidad));
        }

        public void Eliminar(T entidad)
        {
            _lista.Remove(entidad);
        }
    }
}