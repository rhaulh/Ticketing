using System;

namespace Ticketing.Modelos.Utils.FechasYTiempo
{
    public interface IFecha
    {
    }
    public class FechaAsignada : IFecha
    {
        public DateTime Fecha { get; set; }
        public FechaAsignada(int dia, int mes, int año)
        {
            if (dia < 1 || dia > 31)
                throw new ArgumentOutOfRangeException(nameof(dia), "El día debe estar entre 1 y 31.");
            if (mes < 1 || mes > 12)
                throw new ArgumentOutOfRangeException(nameof(mes), "El mes debe estar entre 1 y 12.");
            if (año < 1)
                throw new ArgumentOutOfRangeException(nameof(año), "El año debe ser un número positivo.");
            if (dia > DateTime.DaysInMonth(año, mes))
                throw new ArgumentOutOfRangeException(nameof(dia), "El día no es válido para el mes y año especificados.");
            Fecha = new DateTime(año, mes, dia);
        }
        public FechaAsignada(DateTime fecha)
        {
            Fecha = fecha;
        }
    }
   public sealed class FechaEspecifica : FechaAsignada, IFecha
    {
        public FechaEspecifica(int dia, int mes, int año) : base(dia, mes, año)
        {
        }
        public FechaEspecifica(DateTime fecha) : base(fecha)
        {
        }

        public bool EsAntesDe(FechaEspecifica otraFecha)
        {
            return Fecha.Date < otraFecha.Fecha.Date;
        }
        public bool EsDespuesDe(FechaEspecifica otraFecha)
        {
            return Fecha.Date > otraFecha.Fecha.Date;
        }
        public bool EsIgualA(FechaEspecifica otraFecha)
        {
            return Fecha.Date == otraFecha.Fecha.Date;
        }

        public DateTime Finalizacion(TimeSpan duracion)
        {
            return Fecha.Add(duracion);
        }
        public new string ToString()
        {
            return Fecha.ToString("dd-MM-yyyy");
        }
    }
    public class MesAño : IFecha
    {
        public DateTime Fecha { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public MesAño(int mes, int año)
        {
            Mes = mes;
            Año = año;
        }
        public override string ToString()
        {
            return $"{Mes:D2}/{Año}";
        }
    }
    public class SinFecha : IFecha
    {
        public override string ToString()
        {
            return "Sin fecha";
        }
    }    
}
