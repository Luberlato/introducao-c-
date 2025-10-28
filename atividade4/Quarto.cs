namespace atividade4
{
    public class Quarto
    {
        private static readonly string[] tipos = { "simples", "duplo", "suite" };
        private string tipo = "";

        public int Numero { get; set; }

        public string Tipo
        {
            get { return tipo; }
            set
            {
                bool valido = false;
                foreach (var t in tipos)
                {
                    if (value == t)
                    {
                        tipo = value; // ✅ atribui ao campo, não chama o set de novo
                        valido = true;
                        break;
                    }
                }
                if (!valido)
                {
                    Console.WriteLine("Tipo de quarto inválido! Escolha: simples, duplo ou suite.");
                }
            }
        }

        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; }

        public Quarto(int NumeroConstrutor, string TipoConstrutor, double PrecoDiariaConstrutor, bool DisponivelConstrutor)
        {
            Numero = NumeroConstrutor;
            Tipo = TipoConstrutor;
            PrecoDiaria = PrecoDiariaConstrutor;
            Disponivel = DisponivelConstrutor;
        }

        public Quarto() { }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Número do Quarto: {Numero}");
            Console.WriteLine($"Tipo do Quarto: {Tipo}");
            Console.WriteLine($"Preço da Diária: {PrecoDiaria}");
            Console.WriteLine(Disponivel ? $"O quarto {Numero} está disponível" : "Esse quarto está ocupado");
        }

        public bool Ocupar()
        {
            if (Disponivel)
            {
                Disponivel = false;
            }
            else
            {
                Console.WriteLine("O quarto já está ocupado");
            }
            return Disponivel;
        }

        public bool Liberar()
        {
            if (!Disponivel)
            {
                Disponivel = true;
            }
            else
            {
                Console.WriteLine("O quarto não está ocupado");
            }
            return Disponivel;
        }
    }
}