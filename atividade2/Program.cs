namespace atividade2;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        Circulo circulo = new Circulo();
        retangulo.altura = 5;
        retangulo.largura = 6;
        circulo.raio = 7;
        Console.WriteLine(retangulo.calcularArea());
        Console.WriteLine(circulo.calcularArea());
    }
}
