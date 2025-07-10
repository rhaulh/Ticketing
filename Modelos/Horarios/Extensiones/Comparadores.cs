namespace Ticketing.Modelos.Horarios.Extensiones
{
    public static class Comparadores
    {
        public static bool EsIgualA(this Horario horario, Horario otro)
        {
            return horario.Hora == otro.Hora && horario.Minuto == otro.Minuto && horario.Segundo == otro.Segundo;
        }
        public static bool EsAntesDe(this Horario horario, Horario otro)
        {
            return horario.Hora < otro.Hora ||
                   horario.Hora == otro.Hora && horario.Minuto < otro.Minuto ||
                   horario.Hora == otro.Hora && horario.Minuto == otro.Minuto && horario.Segundo < otro.Segundo;
        }
        public static bool EsDespuesDe(this Horario horario, Horario otro)
        {
            return horario.Hora > otro.Hora ||
                   horario.Hora == otro.Hora && horario.Minuto > otro.Minuto ||
                   horario.Hora == otro.Hora && horario.Minuto == otro.Minuto && horario.Segundo > otro.Segundo;
        }
    }
}
