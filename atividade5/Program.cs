namespace atividade5;

class Program
{
    static void Main(string[] args)
    {
        Carro civic = new Carro("Civic","Honda", 2017, 5);
        civic.Ligar();
        civic.exibirDetalhes();
        Moto ninja = new Moto("Ninja","Kawasaki", 2021, 400);
        ninja.Ligar();
        ninja.exibirDetalhes();
        Transporte aviao = new Transporte(800, "Aviao");
        Console.WriteLine($"Tempo de viagem {aviao.calcularTempoViagem(1600)} horas");

    }
}
