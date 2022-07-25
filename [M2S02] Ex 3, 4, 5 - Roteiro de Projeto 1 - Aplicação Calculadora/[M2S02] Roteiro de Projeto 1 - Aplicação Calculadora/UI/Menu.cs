using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S02__Roteiro_de_Projeto_1___Aplicação_Calculadora.UI
{
    public class Menu
    {
        public static void mainMenu()
        {
            Console.Clear();
            Console.WriteLine(" Escolha o tipo de operação: \n");
            Console.WriteLine(" (1) Adição");
            Console.WriteLine(" (2) Subtração");
            Console.WriteLine(" (3) Multiplicação");
            Console.WriteLine(" (4) Divisão\n");

            Console.WriteLine(" (0) Sair");
        }
    }
}
