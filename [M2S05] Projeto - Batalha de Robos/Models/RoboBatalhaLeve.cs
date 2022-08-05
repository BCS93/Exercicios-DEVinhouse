using _M2S05__Projeto___Batalha_de_Robos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S05__Projeto___Batalha_de_Robos.Models
{
    public class RoboBatalhaLeve : Robo
    {
        public RoboBatalhaLeve(string nomeDoRobo) : base(nomeDoRobo)
        {
        }

        public override int CausarDano()
        {
            Random rand= new Random();
            if (Status == EStatus.Ligado)
            {
                int probCritico = rand.Next(1, 101);

                if (probCritico <= 15)// probabilidade de 15%
                {
                    return 22;
                }
                else
                {
                    return 10;
                }
            }
            else 
            {
                return 0; 
            }
        }
    }
}
