using System;
namespace atividade2
{
    public class Circulo : Forma
    {
        const double pi = System.Math.PI;
        public double raio;

        public override double calcularArea() => pi * (raio * raio);
    }
}