

namespace atividade3
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao
        {
            get;
            set
            {
                if (value > 0)
                {
                    AnoPublicacao = value;
                }
                else
                {
                    Console.WriteLine("Erro! ANo de publicação invalido");
                }
            }
        }
        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine("DETALHES DO LIVRO");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano de publicacao: {AnoPublicacao}");
            Console.WriteLine($"Preco: {Preco:F2}");
            if (EstaDisponivel)
            {
                Console.WriteLine("Esta livre para emprestimo");
            }
            else
            {
                Console.WriteLine("Esta indisponivel");
            }
        }
        public void Emprestar(){
            if (EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine($"O livro: {titulo} foi emprestado com sucesso");
            }
            else
            {
                Console.WriteLine("O livro ja esta emprestado");
            }
        }

    }
}