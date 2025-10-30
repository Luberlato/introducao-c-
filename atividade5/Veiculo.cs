

namespace atividade5
{
    public abstract class Veiculo
    {
        public string modelo { get; set; }
        public string marca { get; set; }
        private uint anoLancamentoVerificado;
        public uint anoLancamento
        {
            get { return anoLancamentoVerificado; }
            set
            {
                if (value <= 1886)
                {
                    Console.WriteLine("Ano invalido");
                }
                else
                {
                    anoLancamentoVerificado = value;
                }
            }

        }
        
        public virtual void Ligar()
        {
            Console.WriteLine($"O veiculo {modelo} está ligando");
        }
        public virtual void exibirDetalhes()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano de lançamento: {anoLancamento}");
        }

    }
}