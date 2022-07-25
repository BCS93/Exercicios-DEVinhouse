using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S02__Roteiro_de_Projeto_1___Aplicação_Calculadora.UI
{
    public class Operacoes
    {
        public static void adicao()
        {
            double num1;
            double num2;
            double soma = 0;

            Console.Clear();
            Console.WriteLine(" Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1 + num2;
            Console.WriteLine($"\n A soma dos números digitados é: {soma}");
            Console.ReadKey();

        }

        public static void subtracao()
        {
            double num1;
            double num2;
            double subtracao = 0;

            Console.Clear();
            Console.WriteLine(" Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            subtracao = num1 - num2;
            Console.WriteLine($"\n A soma dos números digitados é: {subtracao}");
            Console.ReadKey();

        }

        public static void multiplicacao()
        {
            double num1;
            double num2;
            double multiplicacao = 0;

            Console.Clear();
            Console.WriteLine(" Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            multiplicacao = num1 * num2;
            Console.WriteLine($"\n A soma dos números digitados é: {multiplicacao}");
            Console.ReadKey();

        }
        public static void divisao()
        {
            double num1;
            double num2;
            double divisao = 0;

            Console.Clear();
            Console.WriteLine(" Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            divisao = num1 / num2;
            Console.WriteLine($"\n A soma dos números digitados é: {divisao}");
            Console.ReadKey();

        }

    }
}
