

namespace personagens_mvc.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro()
        {}
        public Guerreiro (string nomeConstrutor, int nivelConstrutor) : base(nomeConstrutor, nivelConstrutor)
        {
            nome = nomeConstrutor;
            nivel = nivelConstrutor;
        }
        public override double calcularPoder()
        {
            return nivel * 10;
        }
    }
}