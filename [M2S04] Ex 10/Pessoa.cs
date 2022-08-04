using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S04__Ex_10
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double IMC { get; set; }


        public Pessoa(string nome, int idade, double peso, double altura)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            IMC = 0;
        }

        public double CalculoIMC()
        {
            IMC = Peso / (Altura * Altura);

            return IMC;
        }

        public string CategoriaIMC(double imc)
        {
            
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                return "Peso Normal";
            }
            else 
            {
                return "Acima do Peso";
            }
        }

    }
}
