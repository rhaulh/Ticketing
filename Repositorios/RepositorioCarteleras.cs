using System.Collections.Generic;
using System;
using System.Linq;
using Ticketing.Modelos.Programacion;

public class RepositorioCarteleras<T> where T : Funcion
{
    private readonly List<T> _lista;
    public RepositorioCarteleras(List<T> lista)
    {
        _lista = lista ?? throw new ArgumentNullException(nameof(lista), "La lista de eventos no puede ser nula.");
    }
    public void Agregar(T evento)
    {
        if (evento == null)
            throw new ArgumentNullException(nameof(evento));

        if (_lista.Any(e => e.Id == evento.Id))
            throw new InvalidOperationException($"Ya existe un evento con ID {evento.Id}.");
        _lista.Add(evento);
    }
    public T ObtenerPorId(int id)
    {
        return _lista.FirstOrDefault(e => e.Id == id);
    }
    public bool Eliminar(int id)
    {
        var evento = ObtenerPorId(id);
        if (evento != null)
        {
            _lista.Remove(evento);
            return true;
        }
        return false;
    }
    public List<T> BuscarPorNombre(string nombre)
    {
        return _lista
            .Where(e => e.Nombre != null && e.Nombre.Contains(nombre))
            .ToList();
    }
    public List<T> ObtenerTodos()
    {
        return _lista.ToList();
    }
}