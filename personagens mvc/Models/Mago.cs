using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personagens_mvc.Models
{
    public class Mago : Personagem
    {
        public Mago()
        {}
        public Mago(string nomeConstrutor, int nivelConstrutor) : base(nomeConstrutor, nivelConstrutor)
        {
            nome = nomeConstrutor;
            nivel = nivelConstrutor;
        }
        public override double calcularPoder()
        {
            return nivel * 8 + 20;
        }
    }
}