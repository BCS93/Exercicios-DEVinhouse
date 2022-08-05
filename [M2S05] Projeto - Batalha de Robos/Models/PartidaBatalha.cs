using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S05__Projeto___Batalha_de_Robos.Models
{
    public static class PartidaBatalha
    {
        public static void Batalhar(Robo robo1, Robo robo2, int round)
        {
            bool finalDeBataha = false;

            Console.WriteLine($"Robô 1 - {robo1.NomeDoRobo} está com {robo1.PontosDeVida} pontos de vida");
            Console.WriteLine($"Robô 2 - {robo2.NomeDoRobo} está com {robo2.PontosDeVida} pontos de vida");

            while (finalDeBataha == false && round > 0)
            {

                switch (robo1.Status)
                {
                    case Enums.EStatus.Ligado:
                        robo2.ReduzirPontosDeVida(robo1.CausarDano());
                        break;
                    case Enums.EStatus.Aguardando:
                        robo1.Iniciar();
                        break;
                    case Enums.EStatus.Destruído:
                        finalDeBataha = true;
                        break;
                }

                switch (robo2.Status)
                {
                    case Enums.EStatus.Ligado:
                        robo1.ReduzirPontosDeVida(robo2.CausarDano());
                        break;
                    case Enums.EStatus.Aguardando:
                        robo2.Iniciar();
                        break;
                    case Enums.EStatus.Destruído:
                        finalDeBataha = true;
                        break;
                }

                Console.WriteLine($"\n\nRodadas restantes: {round}\n");
                Console.WriteLine($"Robô 1 - {robo1.NomeDoRobo} está com {robo1.PontosDeVida} pontos de vida");
                Console.WriteLine($"Robô 2 - {robo2.NomeDoRobo} está com {robo2.PontosDeVida} pontos de vida");

                round--;
            }

            // robo1.ReduzirPontosDeVida(robo2.CausarDano());
            // robo2.ReduzirPontosDeVida(robo1.CausarDano());
        }
    }
}
