using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Calculadora
    {
        public static double IoF = 0.06;

        public static double Converte(double cotacao, double comprar)
        {
            double total = cotacao * comprar; // entrada dos parametros para calculo
            return total + total * IoF;       // retorno do valor final para o metodo 'Converte'
        }


    }
}
