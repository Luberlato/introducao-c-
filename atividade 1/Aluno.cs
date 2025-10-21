

namespace atividade_poo
{
    public class Aluno : Pessoa
    {



        public string nomeEscola;
        public virtual void falar() => Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, e estudo na escola {nomeEscola}");
    }

}