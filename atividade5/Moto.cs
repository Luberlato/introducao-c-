

namespace atividade5
{
    public class Moto : Veiculo
    {
        private uint cilindradaVerificada;
        public uint cilindrada
        {
            get { return cilindradaVerificada;}
            set
            {
                if (value < 50)
                {
                    Console.WriteLine("Numero de Cilindrada incorreta");
                }
                else
                {
                    cilindradaVerificada = value;
                }
            }
        }
        public Moto(string modeloConstrutor, string marcaConstrutor, uint anoLancamentoConstrutor, uint cilindradaConstrutor)
        
        {
            modelo = modeloConstrutor;
            marca = marcaConstrutor;
            anoLancamento = anoLancamentoConstrutor;
            cilindrada = cilindradaConstrutor;
        }
        public override void Ligar()
        {
            Console.WriteLine($"A moto de modelo {modelo} de {cilindrada}cc esta pronta");
        }
        public override void exibirDetalhes()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano de lançamento: {anoLancamento}");
            Console.WriteLine($"Cilindradas: {cilindrada}cc");
        }

    }
}