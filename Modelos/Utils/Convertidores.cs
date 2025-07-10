using System;
using Ticketing.Modelos.Programacion;

namespace Ticketing.Modelos.Utils
{
    public static class Convertidores
    {
        public static string IdToString(this int id)
        {
            if (id < 1)
                return string.Empty;

            int letras = 26;
            int index = (id - 1) % letras;
            int ciclo = (id - 1) / letras;

            char letra = (char)('A' + index);
            return ciclo == 0 ? letra.ToString() : $"{letra}{ciclo}";
        }
        public static int StringToId(this string letra)
        {
            if (string.IsNullOrEmpty(letra))
                return 0;

            letra = letra.ToUpperInvariant();
            char ch = letra[0];

            if (ch < 'A' || ch > 'Z')
                return 0;

            int baseId = (ch - 'A') + 1;
            int ciclo = 0;

            if (letra.Length > 1)
            {
                if (!int.TryParse(letra.Substring(1), out ciclo) || ciclo < 1)
                    return 0;
            }

            return baseId + (ciclo * 26);
        }
    }
}
