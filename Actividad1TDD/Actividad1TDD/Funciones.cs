using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1TDD
{
    public class Funciones
    {
        public static long CalcularFactorial(int numero)
        {
            if (numero < 0)
                return -1;

            if (numero == 0)
                return 1;

            long result = 1;
            for (int i = 1; i <= numero; i++)
            {
                result *= i;
            }
            return result;
        }
        public static bool EsContrasenyaValida(string contrasenya)
        {
            return !string.IsNullOrEmpty(contrasenya)
                && contrasenya.Length >= 8
                && contrasenya.Contains('#');
        }
    }
}