using _M2S05__Projeto___Batalha_de_Robos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S05__Projeto___Batalha_de_Robos.Models
{
    public class RoboBatalhaPesado : Robo
    {
        public RoboBatalhaPesado(string nomeDoRobo) : base(nomeDoRobo)
        {
        }

        public override int CausarDano()
        {
            Random rand = new Random();

            Status = EStatus.Aguardando;

            int probCritico = rand.Next(1, 101);

            if (probCritico <= 15)// probabilidade de 15%
            {
                return 45;
            }
            else
            {
                return 20;
            }

        }
    }
}
