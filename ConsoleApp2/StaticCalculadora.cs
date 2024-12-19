using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StaticCalculadora
    {
        public static double Sumar(double sum1, double sum2)
        {
            return sum1 + sum2;
        }
        public static double Restar(double rest1, double rest2)
        {
            return rest1 - rest2;
        }
        public static double Dividir(double div1, double div2)
        {
            return div1 / div2;
        }
        
        public static double Multiplicar(double mult1, double mult2)
        {
            return mult1 * mult2;
        }

    }
}
