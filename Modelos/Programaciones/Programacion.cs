using System;
using Ticketing.Modelos.Utils.FechasYTiempo;

namespace Ticketing.Modelos.Programacion
{
    public class Programacion
    {
        public IFecha Fecha { get; set; }
        public Horario Horario { get; set; }
        public TimeSpan Duracion { get; set; }

        private DateTime Finalizacion() {
            if (Fecha is FechaEspecifica fechaAsignada) {
                return fechaAsignada.Finalizacion(Duracion);
            }
            throw new InvalidOperationException("No se ha especificado una fecha especifica");
        }

        public Programacion(IFecha fecha, Horario horario)
        {
            Horario = horario;
            Fecha = fecha;
        }
        public bool EsIgualA(Programacion otra)
        {
            return Fecha is FechaEspecifica f1 &&
                   otra.Fecha is FechaEspecifica f2 &&
                   f1.EsIgualA(f2);
        }

        //public bool SeSolapaCon(Programacion otra)
        //{
        //    if (Fecha is FechaEspecifica f1 && otra.Fecha is FechaEspecifica f2)
        //    {
        //        if (f1.EsIgualA(f2))
        //        {
        //            f1.
        //            return inicioA < finB && inicioB < finA;
        //        }
        //    }
        //    return false;
        //}
        //public bool EsAntesDe(Cartelera otra)
        //{
        //    return Finalizacion <= otra.Programacion.Finalizacion;
        //}
        //public bool EsDespuesDe(Cartelera otra)
        //{
        //    return Finalizacion >= otra.Programacion.Finalizacion;
        //}
    }
}
