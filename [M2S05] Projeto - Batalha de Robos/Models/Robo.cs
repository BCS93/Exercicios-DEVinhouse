using _M2S05__Projeto___Batalha_de_Robos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M2S05__Projeto___Batalha_de_Robos.Models
{
    public abstract class Robo
    {
        public string NomeDoRobo { get; private set; }
        public int PontosDeVida { get; private set; }
        public EStatus Status { get; protected set; }


        public Robo(string nomeDoRobo)
        {
            NomeDoRobo = nomeDoRobo;
            PontosDeVida = 100;
            Status = EStatus.Desligado;
        }

        public void Iniciar()
        {
            Status = EStatus.Ligado;
        }

        public void Parar()
        {
            Status = EStatus.Desligado;
        }

        public abstract int CausarDano();

        public void ReduzirPontosDeVida(int dano)
        {
            PontosDeVida -= dano;

            if (PontosDeVida <= 0) 
            {
                PontosDeVida = 0;
                Status = EStatus.Destruído;
            }
        }
    }
}
