using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S03__Ex_3___Crie_um_método_para_calcular_a_idade_da_Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int DataDeNascimento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }


        public static int CalcularIdade(Pessoa pessoa)
        {
            int calculoDaIdade = Convert.ToInt32(DateTime.Now.Year - pessoa.DataDeNascimento);

            return calculoDaIdade;
        }
    }
}
