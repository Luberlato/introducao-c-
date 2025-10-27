

namespace atividade4
{
    public class Hospede
    {
        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        
        public Hospede(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}