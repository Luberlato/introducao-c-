

namespace atividade5
{
    public class Carro : Veiculo
    {
        private uint quantidadePortasVerificada;
       public uint quantidadePortas
       
        {
            get { return quantidadePortasVerificada; }
            set
            {
                if (value < 3)
                {
                    Console.WriteLine("Numeros de porta invalido");
                }
                else
                {
                    quantidadePortasVerificada = value;
                }
            }
        }
        public Carro(string modeloConstrutor, string marcaConstrutor, uint anoLancamentoConstrutor, uint quantidadePortasConstrutor)
        
        {
            modelo = modeloConstrutor;
            marca = marcaConstrutor;
            anoLancamento = anoLancamentoConstrutor;
            quantidadePortas = quantidadePortasConstrutor;
        }
        public override void Ligar()
        {
            Console.WriteLine($"O carro {modelo} está pronto para rodar");
        }
        public override void exibirDetalhes()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano de lançamento: {anoLancamento}");
            Console.WriteLine($"Quantidade de portas: {quantidadePortas}");
        }
    }
}