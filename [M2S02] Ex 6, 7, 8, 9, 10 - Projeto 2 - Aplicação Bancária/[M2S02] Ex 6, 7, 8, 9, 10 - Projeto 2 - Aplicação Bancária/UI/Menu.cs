using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S02__Ex_6__7__8__9__10___Projeto_2___Aplicação_Bancária.UI
{
    public class Menu
    {
        public static void mainMenu()
        { 
            Console.ResetColor();
            Console.Clear();
            //Console.ResetColor();
            Console.WriteLine(" Escolha o tipo de operação: \n");
            Console.WriteLine(" (1) Consultar Saldo");
            Console.WriteLine(" (2) Depósito");
            Console.WriteLine(" (3) Saque");
            Console.WriteLine(" (4) Histórico de Transações\n");

            Console.WriteLine(" (0) Sair");
        }
    }
}
