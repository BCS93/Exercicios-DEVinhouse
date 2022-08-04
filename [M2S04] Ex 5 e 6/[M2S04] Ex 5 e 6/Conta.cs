using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S04__Ex_5_e_6
{
    public class Conta
    {
        public string NomeDoCliente { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }


        public Conta(string nomeDoCliente, int numeroDaConta, double saldo)
        {
            NomeDoCliente = nomeDoCliente;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Console.Clear();
            Console.WriteLine("Operação realizada com sucesso.");
            Console.ReadKey();

            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.Clear();
                Console.WriteLine("Seu saldo é insuficiente para realizar essa operação.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Operação realizada com sucesso.");
                Console.ReadKey();

                Saldo -= valor;
            }


        }

        public double ObterSaldo()
        {
            return Saldo;
        }

        public int ObterNumeroConta()
        {
            return NumeroDaConta;
        }

        public string ObterNomeCliente()
        {
            return NomeDoCliente;
        }

        /*public override string ToString()
        {
            return $"{Saldo.ToString("C")}";
        }*/
    }


}
