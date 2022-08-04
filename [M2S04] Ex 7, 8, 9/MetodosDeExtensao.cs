using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S04__Ex_7__8__9
{
    public static class MetodosDeExtensao
    {

        public static string TradutorDeBool(this bool valor)
        {
            return valor ? "O valor da variável é verdadeiro" : "O da valor variável é falso";
        }

        public static int Multiplicador(this int num) 
        {
            return num * num; 
        }

        public static decimal Multiplicador(this decimal num)
        {
            return num * num;
        }

        public static double Multiplicador(this int num1,double num2, double num3)
        {
            return num1 * num2 * num3;
        }

        public static double Multiplicador(this int num1, double num2, double num3=3.8, int num4 = 6)
        {
            return num1*num2*num3*num4;
        }

    }

}
