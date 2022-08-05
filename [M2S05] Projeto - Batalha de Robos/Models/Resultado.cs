using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S05__Projeto___Batalha_de_Robos.Models
{
    public class Resultado
    {
        public static string ResultadoBatalha(Robo robo1, Robo robo2) 
        {
            string resultado = "";

            if (robo1.PontosDeVida <= 0 || robo2.PontosDeVida > robo1.PontosDeVida)
            {
                resultado = $"\nO {robo2.NomeDoRobo} é o vencedor";
            }

            if (robo2.PontosDeVida <= 0 || robo1.PontosDeVida > robo2.PontosDeVida)
            {
                resultado = $"\nO {robo1.NomeDoRobo} é o vencedor";
            }

            if (robo1.PontosDeVida == robo2.PontosDeVida)
            {
                resultado = "\nO resultado foi empate";
            }

            return resultado;
        } 
    }
}
