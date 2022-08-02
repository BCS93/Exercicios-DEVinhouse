using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S04__Ex_1__2__3__4
{
    public class Lampada
    {

        public int Potencia { get; set; }
        public int Voltagem { get; set; }


        public Lampada(int potencia, int voltagem)
        {
            Potencia = potencia;
            Voltagem = voltagem;
        }

        public override string ToString()
        {
            return $"Potência: {Potencia} W\n" +
                   $"Voltagem: {Voltagem} V ";
        }

        public static void Liga()
        {
            Console.WriteLine("A lâmpada ligou\n");
            Console.ReadKey();
        }

        public static void Desliga()
        {
            Console.WriteLine("A lâmpada desligou\n");
            Console.ReadKey();
        }
    }

}
